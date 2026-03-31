using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_ADV01.Classes
{
    public class ReferenceContainer<T> where T : class
    {
        public T Value { get; set; }

        public ReferenceContainer(T value)
        {
            Value = value;
        }

        public void Print()
        {
            if (Value == null)
                Console.WriteLine("Value is null");
            else
                Console.WriteLine(Value.ToString());
        }
    }
}
