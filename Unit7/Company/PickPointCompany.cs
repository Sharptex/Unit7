using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class PickPointCompany : Company
    {
        public PickPointCompany(decimal fixCost, string name, Contacts contacts) : base(name, contacts)
        {
            FixCost = fixCost;
        }

        public decimal FixCost { get; }
    }
}
