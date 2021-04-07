using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class ShopCompany : Company
    {
        public Contacts Storehouse { get; private set; }

        public ShopCompany(string name, Contacts contacts) : base(name, contacts)
        {
            Storehouse = new Contacts("MyShop", "Address");
        }

    }
}
