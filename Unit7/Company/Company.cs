using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class Company
    {
        public string Name { get; set; }

        public Contacts ContactInfo;

        public Company(string name, Contacts contacts)
        {
            Name = name;
            ContactInfo = contacts;
        }
    }
}
