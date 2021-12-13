using System;
using System.IO;
using System.IO.Ports;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataIO
{
    enum DataIOSerialState
    {
        idle,
        waitingData,
        readingData,
    }

    public class DataIOSerial : DataIOBase
    {
        private SerialPort port;
        private DataIOSerialState state = DataIOSerialState.idle;
        private int itId, size;
        private byte[] buffer;

        public event DataIOEventHandler DataChanged;

        public SerialPort Port
        {
            get => port;
            set
            {
                port = value;
                port.DataReceived += Port_DataReceived;
            }
        }

        public void Start()
        {
            port.Open();
            byte[] b = BitConverter.GetBytes(255);
            port.Write(b, 0, 1);
        }

        public void Stop()
        {
            port.DataReceived -= Port_DataReceived;
            port.DiscardInBuffer();
            port.Close();
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (port.BytesToRead > 0)
            {
                DataInTask();
            }
        }

        private void DataInTask()
        {
            switch (state)
            {
                case DataIOSerialState.idle:
                    itId = port.ReadByte();
                    if(itId >= DataLink.Items.Count)
                    {
                        port.DiscardInBuffer();
                        Console.WriteLine("DataIO itId error");
                        return;
                    }
                    size = DataLink.Items[itId].Size;
                    state = DataIOSerialState.waitingData;
                    break;
                case DataIOSerialState.waitingData:
                    if (port.BytesToRead >= size)
                    {
                        state = DataIOSerialState.readingData;
                    }
                    break;
                case DataIOSerialState.readingData:
                    {
                        var obj = DataLink.Items[itId].Ref;
                        var type = obj.GetType();
                        buffer = new byte[size];

                        port.Read(buffer, 0, size);

                        int pId = 0;
                        foreach (var p in type.GetProperties())
                        {
                            var pByteId = DataLink.Items[itId].Properties[pId].Id;
                            var pType = DataLink.Items[itId].Properties[pId].Type;
                            var pValue = DataLink.Items[itId].Properties[pId].Value;
                            dynamic value = DataLinkItem.GetValue(pType.Name, buffer, pByteId);
                            if (pValue != value)
                            {
                                DataLink.Items[itId].Properties[pId].Value = value;
                                p.SetValue(obj, value, null);
                                DataChanged?.Invoke(this, new DataIOEventArgs(obj, p, value));
                            }
                            pId++;
                        }
                        state = DataIOSerialState.idle;
                    }
                    break;
                default:
                    break;
            }
        }

        public void DataOutTask()
        {
            foreach (var item in DataLink.Items)
            {
                if (item.DataChanged)
                {
                    byte[] bytes = new byte[item.Size + 1];
                    int id = DataLink.Items.IndexOf(item);
                    bytes[0] = Convert.ToByte(id);
                    foreach (var p in item.Properties)
                    {
                        byte[] value = BitConverter.GetBytes(p.Value);

                        for (int i = 0; i < value.Length; i++)
                        {
                            bytes[p.Id + i + 1] = value[i];
                        }
                    }
                    port.Write(bytes, 0, bytes.Length);
                }
            }
        }

        private object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            object obj = (object)binForm.Deserialize(memStream);

            return obj;
        }

        public override void Task()
        {

        }
    }
}
