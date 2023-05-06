using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
  /// <summary>
  /// 字典类
  /// </summary>

    class Dictitonary<Key, Value> : IDictitonary<Key, Value>
    {
        private LinkedListDic<Key, Value> list;
        public Dictitonary()
        {
            list = new LinkedListDic<Key, Value>();
        }

        public bool IsEmpty { get { return list.Count == 0; } }

        public bool ContainsKey(Key key)
        {
            return Get(key)!=null;
        }

        public int Count { get { return list.Count; } }

        public void Add(Key key, Value value)
        {
            list.Add(key, value);
        }

        public Value Get(Key key)
        {
           return list.GetValue(key);
        }

        public void Remove(Key key)
        {
            list.Remove(key);
        }

        public void Set(Key key, Value NewValue)
        {
            list.Set(key, NewValue);
        }
    }
}
