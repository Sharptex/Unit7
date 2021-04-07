using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class ShoppingCartItem : Product
    {
        public int Quantity { get; set; }

        public decimal Total
        {
            get { return Quantity * base.Price; }
        }

        public ShoppingCartItem(Product product, int quantity)
        {
            Name = product.Name;
            Description = product.Description;
            Price = product.Price;
            Quantity = quantity;
        }
    }
}
