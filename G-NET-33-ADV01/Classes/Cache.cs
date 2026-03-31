using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_ADV01.Classes
{
    public class CacheItem<TValue>
    {
        public TValue Value { get; set; }
        public DateTime Expiration { get; set; }
    }

    public class Cache<TKey, TValue>
    {
        private readonly Dictionary<TKey, CacheItem<TValue>> _store = new();

        public void Add(TKey key, TValue value, int expirationInSeconds)
        {
            var item = new CacheItem<TValue>
            {
                Value = value,
                Expiration = DateTime.UtcNow.AddSeconds(expirationInSeconds)
            };

            _store[key] = item;
        }

        public TValue Get(TKey key)
        {
            if (_store.ContainsKey(key))
            {
                var item = _store[key];

                if (DateTime.UtcNow <= item.Expiration)
                {
                    return item.Value;
                }
                else
                {
                    _store.Remove(key);
                }
            }

            return default(TValue);
        }

        public bool Contains(TKey key)
        {
            if (_store.ContainsKey(key))
            {
                var item = _store[key];

                if (DateTime.UtcNow <= item.Expiration)
                {
                    return true;
                }
                else
                {
                    _store.Remove(key);
                }
            }

            return false;
        }

        public bool Remove(TKey key)
        {
            return _store.Remove(key);
        }
    }
}
