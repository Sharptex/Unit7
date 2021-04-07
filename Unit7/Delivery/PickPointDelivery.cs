using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class PickPointDelivery : Delivery
    {
        public PickPointCompany PickPoint { get; }

        public PickPointDelivery(string deliveryAddress, DateTime dueDate, PickPointCompany pickPointCompany) : base(deliveryAddress, dueDate)
        {
            PickPoint = pickPointCompany;
        }

        public override decimal GetDeliveryCost(ShoppingCart shoppingCart, string deliveryAddress = null)
        {
            return PickPoint.FixCost;
        }
    }
}
