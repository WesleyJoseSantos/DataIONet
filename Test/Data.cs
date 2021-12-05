using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class IpAddress
    {
        public byte B1 { get; set; }
        public byte B2 { get; set; }
        public byte B3 { get; set; }
        public byte B4 { get; set; }

        public override string ToString()
        {
            return $"{B1}.{B2}.{B3}.{B4}";
        }
    }

    public class MacAddress
    {
        public byte B1 { get; set; }
        public byte B2 { get; set; }
        public byte B3 { get; set; }
        public byte B4 { get; set; }
        public byte B5 { get; set; }
        public byte B6 { get; set; }

        public override string ToString()
        {
            StringBuilder hex = new StringBuilder();
            hex.AppendFormat("{0:x2}:", B1);
            hex.AppendFormat("{0:x2}:", B2);
            hex.AppendFormat("{0:x2}:", B3);
            hex.AppendFormat("{0:x2}:", B4);
            hex.AppendFormat("{0:x2}:", B5);
            hex.AppendFormat("{0:x2}", B6);
            return hex.ToString();
        }
    }

    class DataIn
    {
        public uint Timer { get; set; }
        public bool LedStatus { get; set; }
        public bool Bool { get; set; }
        public int Int { get; set; }
        public int BlinkCount { get; set; }
        public float Float { get; set; }
        public double Double { get; set; }
    }

    class DataOut
    {
        public bool EnableBlink { get; set; }
        public bool ManualCmd { get; set; }
        public int BlinkTimer { get; set; }
    }
}
