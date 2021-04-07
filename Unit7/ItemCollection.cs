using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    public abstract class ItemCollection<T> where T : class
    {
        protected T[] _collection;

        public ItemCollection()
        {
            _collection = new T[0];
        }

        public ItemCollection(T[] collection)
        {
            _collection = collection;
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _collection.Length)
                {
                    return _collection[index];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (index >= 0 && index < _collection.Length)
                {
                    _collection[index] = value;
                }
            }
        }
    }
}
