using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_ADV01.Interface;

public interface IPrintable
{
    void Print();
}

public class Printer<T> where T : IPrintable
{
    public void PrintItem(T item)
    {
        item.Print();
    }
}

public class Document : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing Document...");
    }
}
