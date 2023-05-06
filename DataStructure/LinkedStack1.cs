using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{/// <summary>
/// 链表栈
/// </summary>
/// <typeparam name="T"></typeparam>
    class LinkedStack1 <T>:IStack<T>
    {
        private LinkedList1<T> list;

        public LinkedStack1()
        {
            list = new LinkedList1<T>();
        }
        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

        public T Cheek()
        {
            return list.GetFirst();
        }

        public T Pop()
        {
            return list.RemoveAt(0);
        }

        public void Push(T value)
        {
            list.AddFirst(value);
        }

        public override string ToString()
        {
            return "Stack: Top" + list.ToString();
        }
    }
}
