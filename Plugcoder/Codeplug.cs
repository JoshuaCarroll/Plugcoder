using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    class Codeplug
    {
        public Channels Channels;
        public Contacts Contacts;
        public RxGroups RxGroups;
        public Zones Zones;

        public Codeplug(string filename)
        {
            byte[] bytes = File.ReadAllBytes(filename);

            Channels = new Channels(bytes);
            Contacts = new Contacts(bytes);
            RxGroups = new RxGroups(bytes);
            Zones = new Zones(bytes);
        }

        public override string ToString()
        {
            string rtn = string.Empty;

            rtn = Channels.ToString(rtn);
            rtn = Contacts.ToString(rtn);
            rtn = RxGroups.ToString(rtn);
            rtn = Zones.ToString(rtn);

            return rtn;
        }
    }
}
