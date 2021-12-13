using System;

namespace DataIO
{
    public class Timestamp
    {
        public byte Hour { get; set; }

        public byte Minute { get; set; }

        public byte Second { get; set; }

        public byte[] Millisecond { get; set; }

        public Timestamp() { }

        public Timestamp(int hour, int minute, int second, int ms)
        {
            Hour = Convert.ToByte(hour);
            Minute = Convert.ToByte(minute);
            Second = Convert.ToByte(second);
            Millisecond = BitConverter.GetBytes(ms);
        }

        public Timestamp(byte hour, byte minute, byte second, byte[] ms)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            Millisecond = ms;
        }

        static public Timestamp Now()
        {
            return (new Timestamp(
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second,
                DateTime.Now.Millisecond));
        }

        public byte[] ToBytes()
        {
            var bytes = new byte[7];
            bytes[0] = Hour;
            bytes[1] = Minute;
            bytes[2] = Second;
            bytes[3] = Millisecond[0];
            bytes[4] = Millisecond[1];
            bytes[5] = Millisecond[2];
            bytes[6] = Millisecond[3];
            return bytes;
        }

        public override string ToString()
        {
            return (Hour + ":" + Minute + ":" + Second + ":" + BitConverter.ToUInt16(Millisecond, 0));
        }
    }
}
