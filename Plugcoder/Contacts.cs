using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    class Contacts : MD380RDTObjectGroup
    {
        public Dictionary<int, Contact> Items;

        public Contacts(byte[] bytes)
        {
            Items = new Dictionary<int, Contact>();

            for (int i = this.FirstByte; i < this.LastByte; i += this.BytesPerEntry)
            {
                Contact contact = new Contact(new ArraySegment<byte>(bytes, i, this.BytesPerEntry));

                if (contact.Name.Trim() != string.Empty)
                {
                    Items.Add(contact.ID, contact);
                }
            }
        }
    }
}
