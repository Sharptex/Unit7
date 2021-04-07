using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class HomeDelivery : Delivery
    {
        public CourierCompany CourierCompany { get; set; }

        public HomeDelivery(string deliveryAddress, DateTime dueDate, CourierCompany courierCompany) : base(deliveryAddress, dueDate)
        {
            CourierCompany = courierCompany;
        }

        public override decimal GetDeliveryCost(ShoppingCart shoppingCart, string deliveryAddress)
        {
            var distance1 = GeolocationHelper.GetDistance(CourierCompany.ContactInfo.Address, Shop.Storehouse.Address);
            var distance2 = GeolocationHelper.GetDistance(Shop.Storehouse.Address, deliveryAddress);
            return CourierCompany.DeliveryRate*(distance1+ distance2);
        }

    }
}
