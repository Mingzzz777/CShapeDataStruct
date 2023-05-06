using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{/// <summary>
/// 循环队列
/// </summary>

    class ArrayQueue1<T>:IQueue<T>
    {
        Array1<T> array;

        public int Count { get { return array.Count; } }

        public bool IsEmpty { get { return array.IsEmpty; } }

        public  ArrayQueue1(int capacity) 
        {
            array = new Array1<T>(capacity);
        }
        public ArrayQueue1()
        {
            array = new Array1<T>();
        }
        public T Cheek()      
        {
            return array.GetFirst();
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
            return "Queue head :"+ array.ToString()+"Last";
        }
    }
}
