using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{

    /// <summary>
    /// 字典类接口
    /// </summary>

    interface IDictitonary<Key,Value>
    {
        void Add(Key key, Value value);

        void Remove(Key key);

        Value Get(Key key);

        void Set(Key key,Value NewValue);

        bool IsEmpty { get; }

        bool ContainsKey(Key key);

        int Count { get; }
    }
}
