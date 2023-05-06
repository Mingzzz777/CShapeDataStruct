using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedQueue<T>:IQueue<T>
    {
        LinkedList2<T> array;

        public int Count { get { return array.Count; } }

        public bool IsEmpty { get { return array.IsEmpty; } }

        //public LinkedQueue(int capacity)
        //{
        //    array = new LinkedList2<T>(capacity); ;
        //}
        public LinkedQueue()
        {
            array = new LinkedList2<T>();
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
            return "Queue head :" + array.ToString() + "Last";
        }
    }
}

