using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01
{
    internal class CacheItem<TValue>
    {
        public TValue Value { get; set; }
        public DateTime ExpirationTime { get; set; }
    }
    internal class Cache<TKey, TValue> where TKey : notnull
    {
        private readonly Dictionary<TKey, CacheItem<TValue>> _cacheStorage = new Dictionary<TKey, CacheItem<TValue>>();
     
        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            var expirationTime = DateTime.Now.Add(duration);
            var cacheItem = new CacheItem<TValue> { Value = value, ExpirationTime = expirationTime };

            if (_cacheStorage.ContainsKey(key))
            {
                _cacheStorage[key] = cacheItem;
            }
            else
            {
                _cacheStorage.Add(key, cacheItem);
            }
        }

        public TValue Get(TKey key)
        {
            if (!_cacheStorage.ContainsKey(key))
            {
                return default;
            }
            var item = _cacheStorage[key];
            if (DateTime.Now > item.ExpirationTime)
            {
                _cacheStorage.Remove(key); 
                return default;
            }
            return item.Value;
        }
        public bool Contains(TKey key)
        {
            if (!_cacheStorage.ContainsKey(key))
            {
                return false;
            }

            if (DateTime.Now > _cacheStorage[key].ExpirationTime)
            {
                _cacheStorage.Remove(key);
                return false;
            }

            return true;
        }
        public bool Remove(TKey key)
        {
            return _cacheStorage.Remove(key);
        }
    }
}
