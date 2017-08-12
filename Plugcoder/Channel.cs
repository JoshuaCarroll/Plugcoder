using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    public class Channel : MD380RDTObjectGroup
    {
        public enum Modes
        {
            Analog,
            Digital
        }
        public enum PowerLevels
        {
            High,
            Medium,
            Low
        }
        public Modes Mode;
        public PowerLevels PowerLevel;
        public int ContactIndex;
        public int EmergencyIndex;
        public int ScanListIndex;
        public int ReceiveGroupIndex;
        public double ReceiveFrequency;
        public double TransmitFrequency;
        public string Name;


        public Channel(Modes mode, PowerLevels powerLevel, int contactIndex, int receiveGroupIndex, double receiveFreq, double transmitFreq, string name)
        {
            Mode = mode;
            PowerLevel = powerLevel;
            ContactIndex = contactIndex;
            ReceiveGroupIndex = receiveGroupIndex;
            ReceiveFrequency = receiveFreq;
            TransmitFrequency = transmitFreq;
            Name = name;
        }

        public Channel(ArraySegment<byte> bytes)
        {
            if (bytes.Count == this.BytesPerEntry)
            {
                ContactIndex = (bytes.Array[bytes.Offset + 6].ToString("X2") + bytes.Array[bytes.Offset + 7].ToString("X2")).hexToDec();
                EmergencyIndex = (bytes.Array[bytes.Offset + 10].ToString("X2")).hexToDec();
                ScanListIndex = (bytes.Array[bytes.Offset + 11].ToString("X2")).hexToDec();
                ReceiveGroupIndex = (bytes.Array[bytes.Offset + 12].ToString("X2")).hexToDec();

                string rx = bytes.Array[bytes.Offset + 19].ToString("X2") + bytes.Array[bytes.Offset + 18].ToString("X2") + bytes.Array[bytes.Offset + 17].ToString("X2") + bytes.Array[bytes.Offset + 16].ToString("X2");
                if (rx != "FFFFFFFF")
                {
                    ReceiveFrequency = double.Parse(rx) / 10000;
                }

                string tx = bytes.Array[bytes.Offset + 23].ToString("X2") + bytes.Array[bytes.Offset + 22].ToString("X2") + bytes.Array[bytes.Offset + 21].ToString("X2") + bytes.Array[bytes.Offset + 20].ToString("X2");
                if (tx != "FFFFFFFF")
                {
                    TransmitFrequency = double.Parse(tx) / 10000;
                }

                for (int i = bytes.Offset + 32; i < bytes.Offset + BytesPerEntry; i += 2)
                {
                    string hexValue = bytes.Array[i + 1].ToString("X2") + bytes.Array[i].ToString("X2");

                    if (hexValue != "0000")
                    {
                        Name += hexValue.hexToAscii();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                throw new FormatException("Invalid data creating channel");
            }
        }
    }
}
