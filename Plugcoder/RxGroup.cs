using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    class RxGroup : MD380RDTObjectGroup
    {
        public string Name;
        public List<int> ContactIndex;

        public RxGroup(ArraySegment<byte> bytes)
        {
            if (bytes.Count == this.BytesPerEntry)
            {
                Name = "";
                for (int i = bytes.Offset + 0; i < bytes.Offset + 32; i+=2)
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

                ContactIndex = new List<int>();
                for (int i = bytes.Offset + 32; i < bytes.Offset + 96; i += 2)
                {
                    string hexValue = bytes.Array[i + 1].ToString("X2") + bytes.Array[i].ToString("X2");

                    if (hexValue != "0000")
                    {
                        ContactIndex.Add(hexValue.hexToDec());
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                throw new FormatException("Invalid data creating receive group");
            }
        }
    }
}
