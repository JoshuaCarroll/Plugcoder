using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    public class MD380RDTObjectGroup
    {
        public int FirstByte
        {
            get
            {
                Type t = this.GetType();
                switch (t.Name)
                {
                    case "Contacts":
                    case "Contact":
                        return 24997;
                    case "RxGroups":
                    case "RxGroup":
                        return 60997;
                    case "Zones":
                    case "Zone":
                        return 84997;
                    case "ScanLists":
                    case "ScanList":
                        return 100997;
                    case "Channels":
                    case "Channel":
                        return 127013;
                    default:
                        return 0;
                }
            }
        }
        public int LastByte
        {
            get
            {
                Type t = this.GetType();
                switch (t.Name)
                {
                    case "Contacts":
                    case "Contact":
                        return 60996;
                    case "RxGroups":
                    case "RxGroup":
                        return 84996;
                    case "Zones":
                    case "Zone":
                        return 100996;
                    case "ScanLists":
                    case "ScanList":
                        return 126997;
                    case "Channels":
                    case "Channel":
                        return 191012;
                    default:
                        return 0;
                }
            }
        }
        public int BytesPerEntry
        {
            get
            {
                Type t = this.GetType();
                switch (t.Name)
                {
                    case "Contacts":
                    case "Contact":
                        return 36;
                    case "RxGroups":
                    case "RxGroup":
                        return 96;
                    case "Zones":
                    case "Zone":
                        return 64;
                    case "ScanLists":
                    case "ScanList":
                        return 104;
                    case "Channels":
                    case "Channel":
                        return 64;
                    default:
                        return 0;
                }
            }
        }

        public string ToString(string strToConcatenate)
        {
            strToConcatenate += ToString() + "\r\n\r\n";
            return strToConcatenate;
        }
        public override string ToString()
        {
            Type t = this.GetType();

            string rtn = "____ " + t.Name.ToUpper() + " ____\r\n";

            switch (t.Name)
            {
                case "Channels":
                    Channels channels = (Channels)this;
                    for (int i = 0; i < channels.Items.Count; i++)
                    {
                        Channel obj = channels.Items.ToList()[i].Value;
                        rtn += obj.Name + " " + channels.Items.ToList()[i].Key.ToString() + " " + obj.Name + "\r\n";
                    }
                    break;
                case "Contacts":
                    Contacts contacts = (Contacts)this;
                    for (int i = 0; i < contacts.Items.Count; i++)
                    {
                        Contact obj = contacts.Items.ToList()[i].Value;
                        rtn += obj.Name + " " + obj.ID.ToString() + " " + obj.Name + "\r\n";
                    }
                    break;
                case "RxGroups":
                    RxGroups rxGroups = (RxGroups)this;
                    for (int i = 0; i < rxGroups.List.Count; i++)
                    {
                        RxGroup obj = rxGroups.List[i];
                        rtn += obj.Name + " " + obj.Name + "\r\n";
                    }
                    break;
                case "Zones":
                    Zones zones = (Zones)this;
                    for (int i = 0; i < zones.List.Count; i++)
                    {
                        Zone obj = zones.List[i];

                        rtn += obj.Name + "(Contact indexes: ";

                        for (int j = 0; j < obj.ChannelIndexList.Count; j++)
                        {
                            rtn += obj.ChannelIndexList[j].ToString();

                            if (j < obj.ChannelIndexList.Count - 1)
                            {
                                rtn += ", ";
                            }
                        }

                        rtn += ")\r\n";
                    }
                    break;
                case "ScanLists":
                    rtn += "ScanLists.ListItems() not implemented.\r\n";
                    break;
            }

            return rtn;
        }
    }
}
