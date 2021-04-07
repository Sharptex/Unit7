using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public class PriceList : ItemCollection<Product>
    {
        public PriceList(Product[] collection) : base(collection)
        {
        }
    }
}
