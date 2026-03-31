using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_ADV01.Classes
{
    public interface IDisplay
    {
        void Display();
    }

    public class Employee : Person, IDisplay
    {
        public void Display()
        {
            Console.WriteLine($"Employee: {Name}");
        }
    }

    public class Handler<T> where T : Person, IDisplay, new()
    {
        public T CreateAndDisplay()
        {
            T obj = new T();
            obj.Display();
            return obj;
        }
    }

   
}
