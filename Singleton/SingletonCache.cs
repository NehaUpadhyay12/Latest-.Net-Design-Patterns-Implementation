using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonCache : ICache
    {
        private static readonly SingletonCache _instance = new SingletonCache();
        private ConcurrentDictionary<object, object> cacheEntries = new ConcurrentDictionary<object, object>();
        private SingletonCache() { }
        public static SingletonCache Instance { get {  return _instance; } }
        public bool Add(object key, object value)
        {
            return cacheEntries.TryAdd(key, value);
        }

        public object Get(object key)
        {
            if (cacheEntries.TryGetValue(key, out object value))
                return value;
            else return null;
        }

        public object[] GetAll()
        {
            return cacheEntries.Values.ToArray();
        }

        public bool Remove(object key)
        {
            return cacheEntries.TryRemove(key, out object value);
        }

        public void Clear()
        {
            cacheEntries.Clear();
        }
    }
}
