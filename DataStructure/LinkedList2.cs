using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{/// <summary>
/// 有头尾指针的链表，用于链队列
/// </summary>
/// <typeparam name="T"></typeparam>
    class LinkedList2<T>
    {
        private Node head;
        private Node tail;
        private int N;
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }
        private class Node  //节点类
        {
            public T value; //节点存储的值
            public Node next;//下一个节点

            /// <summary>
            /// 初始化节点
            /// </summary>
            public Node(T value, Node next)
            {
                this.value = value;
                this.next = next;
            }
            public Node(T value)
            {
                this.value = value;
                this.next = null;
            }
            public override string ToString()
            {
                return value.ToString();
            }
        }

        public LinkedList2()
        {
            head = null;//头
            tail = null;//尾
            N = 0; //数组元素数量
        }

        public void AddLast(T value)
        {
            if (IsEmpty)
            {
                Node node = new Node(value);
                tail = node;
                head = node;
            }
            else
            {
                Node node = new Node(value);
                tail.next = node;
                tail = node;
            }
            N++;
        }
        public T RemoveFirst()
        {
            T temp = head.value;

            head = head.next;
            N--;

            if (IsEmpty)
            {
                tail = null;
            }
            return head.value;
        }

        public T GetFirst()
        {
            return head.value;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node headPointer = head;
        

            while (headPointer != null)
            {
                res.Append(headPointer.value + "-->");
                headPointer = headPointer.next;
            }
            res.Append("NULL");

            return res.ToString();
        }
    }
}
