using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class CourierCompany : Company
    {
        public CourierCompany(decimal deliveryRate, string name, Contacts contacts) : base(name, contacts)
        {
            DeliveryRate = deliveryRate;
        }

        public decimal DeliveryRate { get; }
    }
}
