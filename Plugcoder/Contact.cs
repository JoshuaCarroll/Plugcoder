using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    class Contact : MD380RDTObjectGroup
    {
        public int ID;
        public string Type;
        public string Name;

        public Contact() { }

        public Contact(ArraySegment<byte> bytes)
        {
            if (bytes.Count == this.BytesPerEntry)
            {
                string strIdHex = bytes.Array[bytes.Offset + 2].ToString("X2") + bytes.Array[bytes.Offset + 1].ToString("X2") + bytes.Array[bytes.Offset + 0].ToString("X2");
                ID = strIdHex.hexToDec();

                switch (bytes.Array[bytes.Offset + 3].ToString("X2"))
                {
                    case "C1":
                        Type = "Group";
                        break;
                    case "C2":
                        Type = "Private";
                        break;
                    case "C3":
                        Type = "All";
                        break;
                    case "C0":
                    default:
                        Type = "";
                        break;
                }

                Name = "";
                for (int i = bytes.Offset + 4; i < bytes.Offset + 36; i+=2)
                {
                    string hexValue = bytes.Array[i + 1].ToString("X2") + bytes.Array[i].ToString("X2");

                    if (hexValue != "0000")
                    {
                        Name += hexValue.hexToAscii();
                    }
                }
            }
            else
            {
                throw new FormatException("Invalid data creating contact");
            }
        }
    }
}
