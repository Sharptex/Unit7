using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        public int Id { get; private set; }

        public OrderStatus Status { get; set; }

        public ShoppingCart Cart { get; private set; }

        public TDelivery Delivery { get; private set; }

        public decimal DeliveryCost 
        { 
            get
            {
                return Delivery.GetDeliveryCost(Cart, Delivery.Address);
            }
        }

        public string Description 
        { 
            get 
            {
                return this.ToString();
            }
        }

        public Order(int id, ShoppingCart cart, TDelivery delivery)
        {
            Id = id;
            Status = OrderStatus.Accepted;
            Delivery = delivery;
            Cart = cart;
        }

        public decimal Total
        {
            get { return Cart.SumTotal + DeliveryCost; }
        }

        public override string ToString()
        {
            return $"Order contains {Cart.Items.Length} items, total sum {Total} with delivery cost {DeliveryCost}, delivery address: {Delivery.Address}, due date: {Delivery.DueDate}"; 
        }
    }
}
