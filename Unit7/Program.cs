using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    class Program
    {
        static void Main(string[] args)
        {
            var prods = new Product[] { new Product("Стол", "", 1000),
                                        new Product("Стул", "", 2000),
                                        new Product("Ноутбук", "", 30000)};

            PriceList price = new PriceList(prods);

            var item1 = new ShoppingCartItem(price[0], 1);
            var item2 = new ShoppingCartItem(price[1], 3);
            var item3 = new ShoppingCartItem(price[2], 5);

            ShoppingCart cart = new ShoppingCart();
            cart += item1;
            cart += item2;
            cart += item3;

            //example - selected home delivery
            var selectedCourierCompany = new CourierCompany(2, "Пегас", new Contacts("911", "г. Москва, ул. Московская 99"));
            var selectedDelivery = new HomeDelivery("г. Москва, ул. Моя улица, д.1, кв. 1", DateTime.Now.AddDays(3), selectedCourierCompany);

            var order1 = new Order<HomeDelivery>(1, cart, selectedDelivery);

            Console.WriteLine(order1);

            Console.ReadKey();
        }
    }
}
