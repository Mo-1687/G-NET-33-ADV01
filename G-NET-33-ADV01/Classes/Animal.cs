using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_ADV01.Classes
{
    public class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class AnimalProcessor<T> where T : Animal
    {
        public void Process(T animal)
        {
            animal.Speak(); 
        }
    }
}
