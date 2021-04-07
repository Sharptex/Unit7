using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public abstract class Delivery
    {
        public string Address { get; private set; }
        public DateTime DueDate { get; private set; }
        public static ShopCompany Shop { get; private set; }
        static Delivery()
        {
            Shop = new ShopCompany("MyShop", new Contacts("800", "Адрес магазина"));
        }
        public Delivery(string deliveryAddress, DateTime dueDate)
        {
            Address = deliveryAddress;
            DueDate = dueDate;
        }

        public abstract decimal GetDeliveryCost(ShoppingCart shoppingCart, string deliveryAddress);
    }
}
