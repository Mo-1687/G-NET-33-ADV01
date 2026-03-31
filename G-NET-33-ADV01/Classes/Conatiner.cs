using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_ADV01.Classes
{
    public class Container<T>
    {
        private T _value;

        // Add method to store a value
        public void Add(T value)
        {
            _value = value;
        }

        // Get method to retrieve the value
        public T Get()
        {
            return _value;
        }
    }

       
}
