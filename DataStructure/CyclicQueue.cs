using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{/// <summary>
/// 循环队列
/// </summary>
/// <typeparam name="T"></typeparam>
    class CyclicQueue<T>:IQueue<T>
    {
        CyclicArray1<T> array;

        public int Count { get { return array.Count; } }

        public bool IsEmpty { get { return array.IsEmpty; } }

        public CyclicQueue(int capacity)
        {
            array = new CyclicArray1<T>(capacity); ;
            
        }
        public CyclicQueue()
        {
            array = new CyclicArray1<T>();
        }
        public T Cheek()
        {
            return array.GetFrist();
        }

        public T DeQueue()
        {
            return array.RemoveFirst();
        }

        public void EnQueue(T value)
        {
            array.AddLast(value);
        }

        public override string ToString()
        {
            return "Queue head :" + array.ToString() + "Last";
        }
    }
}
