using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    static class ShoppingCartItemArrayExtensions
    {
        public static ShoppingCartItem[] Add(this ShoppingCartItem[] source, ShoppingCartItem item)
        {
            ShoppingCartItem[] result = new ShoppingCartItem[source.Length + 1];
            for (int i = 0; i < source.Length; i++)
            {
                result[i] = source[i];
            }
            result[result.Length - 1] = item;

            return result;
        }

        public static ShoppingCartItem[] Remove(this ShoppingCartItem[] source, ShoppingCartItem item)
        {
            if (source.Length < 1 || !source.Contains(item)) { return source; }
            ShoppingCartItem[] result = new ShoppingCartItem[source.Length - 1];
            int index = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != item)
                {
                    result[index] = source[i];
                    index += 1;
                }
            }
            return result;
        }
    }
}
