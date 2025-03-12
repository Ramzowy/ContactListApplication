using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp
{
    public class ContactGroup : List<Contact>
    {
        public string groupName { get; set; } = string.Empty;
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public ContactGroup(string name, List<Contact> Contacts) : base(Contacts)
        {
            groupName = name;
        }
    }
}
