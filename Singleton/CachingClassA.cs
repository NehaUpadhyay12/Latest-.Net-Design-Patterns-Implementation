using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class CachingClassA
    {
        public CachingClassA()
        {
            SingletonCache cacheA = SingletonCache.Instance;
            cacheA.Add("cacheA1", "This is Cache A class entry 1");
            cacheA.Add("cacheA2", "This is Cache A class entry 2");
            cacheA.Add("cacheA3", "This is Cache A class entry 3");
        }
    }
}
