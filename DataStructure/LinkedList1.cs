using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{/// <summary>
/// 链表(只有头指针)
/// </summary>
/// <typeparam name="T"></typeparam>
    class LinkedList1<T>
    {
        private class Node  //节点类
        {
            public T value; //节点存储的值
            public Node next;//下一个节点

            /// <summary>
            /// 初始化节点
            /// </summary>
            public Node(T value,Node next)
            {
                this.value = value;
                this.next=next;
            }
            public Node(T value)
            {
                this.value = value;
                this.next =null;
            }
            public override string ToString()
            {
                return value.ToString();
            }
        }
        private Node head;
        private int N;
        public LinkedList1()
        {
            head = null;
            N = 0;
        }

        public int Count //获取数组个数
        {
            get { return N; }
        }

        public bool IsEmpty //判断数组是否为空
        {
            get { return N == 0; }
        }
        /// <summary>
        /// 链表的添加方法
        /// </summary>
        public void Add(int index,T value)
        {
            // 头插法
            if (index == 0)  
            {
                Node node = new Node(value);
                //  插入算法核心
                node.next = head;
                head = node;

               // head = new Node(value, head); 高级方法
            }
            else
            {
                Node headPointer = head;//临时指针

                for (int i = 0; i < index-1; i++)
                {
                    headPointer = headPointer.next;
                }
                Node node = new Node(value);
                node.next = headPointer.next;
                headPointer.next = node;

               // headPointer.next = new Node(value, headPointer.next);
            }
            N++;
        }
        public void AddFirst(T value)
        {
            Add(0, value);
        }
        public void AddLast(T value)
        {
            Add(N, value);
        }
        /// <summary>
        /// 获取链表元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetValue(int index) 
        {

            Node headPointer = head;
            for (int i = 0; i < index; i++)
            {
                headPointer = headPointer.next;
            }
            return headPointer.value;
        }
        public T GetFirst()
        {
          return  GetValue(0);
        }

        public T GetLast()
        {
            return GetValue(N);
        }
       /// <summary>
       /// 判断链表里面是否包含 某个元素
       /// </summary>
       /// <returns></returns>
        public bool Contian(T value)
        {
            Node headPointer = head;
            for (int i = 0; i < N; i++)
            {
                if (headPointer.value.Equals(value))
                {
                    return true;
                }
                    headPointer = headPointer.next;
            }
            return false;
        }
        /// <summary>
        ///  删除链表中指定索引的元素
        /// </summary>
        public T RemoveAt(int index)
        {
            Node delNode = head;

            if (index == 0)
            {
                head = delNode.next;
                N--;
                return delNode.value;
               
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    delNode = delNode.next;
                }
                delNode.next = delNode.next.next;
                N--;
                return delNode.value;
                
            }
           
        }
        /// <summary>
        ///  删除链表中指定value的元素
        /// </summary>
        public void RemoveValue(T value)
        {
           //如果value 在头指针
            if (head.value .Equals(value))
            {
                head=head.next;
                N--;
            }
            else
            {
                Node delNode=head;//寻找要删除的value
                Node pre=null; //delNode的前一位节点
                while (delNode != null)
                {
                    //找到value 退出while循环
                    if (delNode.value.Equals(value)) 
                        break;
                    pre = delNode;
                    delNode = delNode.next;
                }
                //退出循环后有两种结果 如果没找到 delNode=null 反之
                if (delNode != null)//找到value
                {
                    //变换指针
                    pre.next = pre.next.next;
                }
                N--;
            }
           
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node headPointer = head;
          //  res.Append(string.Format("count{0}\n", N));

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
