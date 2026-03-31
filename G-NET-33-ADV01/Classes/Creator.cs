using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_ADV01.Classes
{
    public class Creator<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T(); 
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person() 
        {
            Name = "Default";
        }
    }
}
