using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_ADV01.Classes;

public class SafeList<T>
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    // Get item safely
    public T Get(int index)
    {
        if (index >= 0 && index < _items.Count)
        {
            return _items[index];
        }

        return default(T); 
    }

    public int Count => _items.Count;
}
