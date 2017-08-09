using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    class Contacts : MD380RDTObjectGroup
    {
        public List<Contact> List;

        public Contacts(byte[] bytes)
        {
            List = new List<Contact>();

            for (int i = this.FirstByte; i < this.LastByte; i += this.BytesPerEntry)
            {
                Contact contact = new Contact(new ArraySegment<byte>(bytes, i, this.BytesPerEntry));

                if (contact.ID != 16777215)
                {
                    List.Add(contact);
                }
            }
        }
    }
}
