using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal interface ICache
    {
        bool Add(object key, object value);
        bool Remove(object key);
        object Get(object key);
        object[] GetAll();
        void Clear();
    }
}
