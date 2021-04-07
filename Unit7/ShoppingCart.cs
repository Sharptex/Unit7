using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class ShoppingCart : ItemCollection<ShoppingCartItem>
    {
        public ShoppingCartItem[] Items
        {
            get { return _collection; }
            private set { _collection = value; }
        }

        public ShoppingCart(): base()
        {
        }

        public ShoppingCart(ShoppingCartItem[] collection) : base(collection)
        {
        }

        public decimal SumTotal
        {
            get 
            {
                decimal sum = 0;
                foreach (var item in _collection)
                {
                    sum += item.Total;
                }
                
                return sum; 
            }
        }

        public static ShoppingCart operator + (ShoppingCart cart, ShoppingCartItem item)
        {
            return new ShoppingCart(cart._collection.Add(item));
        }

        public static ShoppingCart operator -(ShoppingCart cart, ShoppingCartItem item)
        {
            return new ShoppingCart(cart._collection.Remove(item));
        }
    }
}
