using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class CachingClassB
    {
        public CachingClassB() 
        {
            SingletonCache cacheB = SingletonCache.Instance;
            cacheB.Add("cacheB1", "This is Cache B class entry 1");
            cacheB.Add("cacheB2", "This is Cache B class entry 2");
            cacheB.Add("cacheB3", "This is Cache B class entry 3");
        }
    }
}
