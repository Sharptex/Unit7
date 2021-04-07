using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class ShopDelivery : Delivery
    {
        public ShopDelivery(string deliveryAddress, DateTime dueDate) : base(deliveryAddress, dueDate)
        {
        }
        
        public override decimal GetDeliveryCost(ShoppingCart shoppingCart, string deliveryAddress)
        {
            //Shop delivery is free of cost
            return 0;
        }
    }
}
