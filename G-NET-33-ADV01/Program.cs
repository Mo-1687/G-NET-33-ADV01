using G_NET_33_ADV01.Classes;
using G_NET_33_ADV01.Interface;

namespace G_NET_33_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region A1
            /*
             A generic class is a class that is defined with a type parameter, 
             allowing it to work with different data types 
             while maintaining type safety.
             */
            #endregion

            #region A2
            Container<int> intContainer = new Container<int>();
            intContainer.Add(5);
            Console.WriteLine(intContainer.Get());

            #endregion

            #region A3
            /*
             Multiple type parameters mean a generic class (or method) 
             can work with more than one data type at the same time.
             */
            Pair<int, string> pair1 = new Pair<int, string>(1, "Apple");
            Console.WriteLine(pair1.GetKey()); 
            Console.WriteLine(pair1.GetValue());
            #endregion

            #region A4
            /*
              A generic method is a method that uses type parameters (like <T>) 
              so it can work with different data types without 
              rewriting the method for each type.
             */

            int x = 5, y = 10;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}"); 

            string s1 = "Hello", s2 = "World";
            Swap(ref s1, ref s2);
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            #endregion

            #region A5
            int maxInt = FindMax(10, 20);
            Console.WriteLine(maxInt);

            string maxString = FindMax("Apple", "Banana");
            Console.WriteLine(maxString);
            #endregion

            #region A6
            /*
             A generic interface is an interface that uses type parameters (<T>), 
             allowing it to define methods that work with any data type.
            The example is create as an interface file.
             */
            #endregion

            #region A7
            /*
             The struct constraint in C# is used in generics to restrict 
             the type parameter T to value types only.
            public class ValueContainer<T> where T : struct
        {
             public T Value { get; set; }

             public ValueContainer(T value)
            {
                 Value = value;
            }

             public void Display()
             {
                     Console.WriteLine(Value);
            }
          }
                        
             */
            #endregion

            #region A8
            /*
             The class constraint in C# generics 
             restricts the type parameter T to reference types only.
             */
            ReferenceContainer<string> strContainer = new ReferenceContainer<string>("Hello");
            strContainer.Print();

            ReferenceContainer<object> objContainer = new ReferenceContainer<object>(new object());
            objContainer.Print();
            #endregion

            #region A9
            /*
             The new() constraint in C# generics ensures that 
            the type parameter T has a public parameter-less 
            constructor (a constructor with no arguments).
             */

            Creator<Person> creator = new Creator<Person>();
            Person person = creator.CreateInstance();

            Console.WriteLine(person.Name);
            #endregion

            #region A10
            /*
             The interface constraint in C# generics restricts a type parameter T 
             to types that implement a specific interface. 
            */

            Printer<Document> printer = new Printer<Document>();
            Document doc = new Document();

            printer.PrintItem(doc);
            #endregion

            #region A11
            /*
             The base class constraint in C# generics 
             restricts a type parameter T to be a specific 
             base class or any of its derived (child) classes.
             */

            AnimalProcessor<Dog> processor = new AnimalProcessor<Dog>();
            Dog dog = new Dog();

            processor.Process(dog);
            #endregion

            #region A12
            /*
             generics, you can apply multiple constraints to a type 
             parameter using a where clause. This allows you to restrict 
             a generic type to satisfy more than one condition at the same time.
             */

            Handler<Employee> handler = new Handler<Employee>();

            Employee emp = handler.CreateAndDisplay();
            emp.Name = "John";

            emp.Display(); // Output: Employee: John
            #endregion

            #region A13
            /*
             the default keyword is used to return the default value 
             of a type parameter T.
             */
            #endregion

            #region A14
            SafeList<int> numbers = new SafeList<int>();
            numbers.Add(10);
            numbers.Add(20);

            Console.WriteLine(numbers.Get(0));
            Console.WriteLine(numbers.Get(5));

            SafeList<string> names = new SafeList<string>();
            names.Add("Alice");

            Console.WriteLine(names.Get(0));
            Console.WriteLine(names.Get(3));
            #endregion

            #region A15
            /*
             Covariance  allows you to use a more 
             derived type than originally specified.

            The out keyword is used in generic type 
            definitions to indicate covariance.
             */
            #endregion

            #region A16
            /*
             Contravariance in C# generics allows you to use a less 
             derived (more general) type than originally specified.

            The in keyword is used in generic type 
            definitions to indicate contravariance.
             */
            #endregion

            #region A17
            /*
             Covariance (out)
                Allows using a more derived type than originally specified.
                Used for output (return values).
                Applies when you are reading data.

            Contravariance (in)
                Allows using a less derived (more general) type.
                Used for input (method parameters).
                Applies when you are passing data into methods.
             */
            #endregion

            #region A18
            /*
             static members in generic types are not shared across different type arguments.
            Instead, each closed generic type gets its own separate copy of static members.
             */
            #endregion

            #region A19
            /*
             you can inherit from a generic class in two main ways:
                1-Specify a concrete type
                2-Keep the class generic and pass the type parameter
             */
            #endregion

            #region A20
            Cache<string, string> cache = new Cache<string, string>();

            cache.Add("username", "Mohamed", 5);

            Console.WriteLine(cache.Get("username")); 

            Console.WriteLine(cache.Contains("username")); 

            System.Threading.Thread.Sleep(6000);
            Console.WriteLine(cache.Get("username"));
            Console.WriteLine(cache.Contains("username"));
            #endregion
        }

        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;
            else
                return b;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
