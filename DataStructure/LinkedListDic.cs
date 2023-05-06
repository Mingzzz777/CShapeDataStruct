using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 服务于字典类的底层链表，拥有两个泛型参数
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    class LinkedListDic<Key, Value>
    {
        private class Node
        {
            public Key key;
            public Value value;
            public  Node next;

            public Node(Key key,Value value,Node next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }
            public override string ToString()
            {
                return key.ToString() + " : " + value.ToString();
        }
        }

        private Node head;
        public int N;
        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        public LinkedListDic()
        {
            head = null;
            N=0;
        }
        /// <summary>
        /// 获取对应键值得节点 便于Add和Contains方法的实现
        /// </summary>

        private Node GetNode(Key key)
        {
            Node cur = head;

            while (cur != null)
            {
                if (cur.key.Equals(key))
                {
                    return cur;
                }
                    cur = cur.next;
            }
            return null;
        }
        /// <summary>
        /// 向列表添加元素
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(Key key ,Value value)
        {
            Node node = GetNode(key);
            if (node == null)
            {
               head = new Node(key, value, head);
                N++;
            }
            else
            {
               
                node.value = value;
            }
        }
        /// <summary>
        /// 查询链表是否已经包含Key
        /// </summary>

        public bool Contains(Key key)
        {
            return GetNode(key) != null;
        }

        /// <summary>
        /// 修改对应Key的Value 去重操作
        /// </summary>

        public void Set(Key key,Value value)
        {
            Node node = GetNode(key);
            if (node != null)
            {
                node.value = value;
            }
            else
            {
                    throw new ArgumentException("键" + key + "不存在");
            }
        }
        /// <summary>
        /// 通过Key获取对应的Value
        /// </summary>

        public Value GetValue(Key key)
        {
            Node node = GetNode(key);
            if (node != null) 
            {
                return node.value;
            }
            else
            {
                Console.WriteLine(key);
                throw new ArgumentException("键" + key + "不存在");
            }
        }
        public void Remove(Key key)
        {
           
            if (head.key .Equals(key))
            {
                head = head.next;
            }
            else
            {
                Node cur = head;
                Node pre = null;

                while (cur != null)
                {
                    if (cur.key.Equals(key))
                    {
                        break;
                    }
                    pre = cur;
                    cur = cur.next;
                }
                if (cur != null)
                {
                    pre.next = cur.next.next;
                    N--;
                }
            }
         
            
        }

    }
}
