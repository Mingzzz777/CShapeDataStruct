using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 哈希表  拉链表示法
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    class HashL1<Key>
    {
        //链条数组
        private LinkedList1<Key> []hashList;
        private int N;
        private int M;
        
        public HashL1(int m)
        {
            int N = 0;
            int M = m;
            hashList = new LinkedList1<Key>[m];
            for (int i = 0; i < M; i++)
            {
                //初始化M条链条
                hashList[i] = new LinkedList1<Key>();
            }
        }
        /// <summary>
        /// 获取哈希值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int getHash(Key key)
        {
            return (key.GetHashCode() & 0x7ffffff)%M;
        }

        public void Add(Key key)
        {
            //list 临时变量
            LinkedList1<Key> list = hashList[getHash(key)];
            if (list.Contian(key)) return;
            else
            {
                list.AddLast(key);
                N++;
            }
        }

       public void Remove(Key key)
        {
            LinkedList1<Key> list = hashList[getHash(key)];

            if (list.Contian(key)) 
            {
                list.RemoveValue(key);
                N--;
            }

        }

        public bool Contain(Key key)
        {
            LinkedList1<Key> list = hashList[getHash(key)];
            return list.Contian(key);
        }

    }
}
