using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 有序数组
    /// </summary>
    class SortedArray<Key> where Key : IComparable<Key> //  限定泛型Key 是可以比较的类型
    {
        Key[] keys;
        int N;
        public SortedArray(int capacity)
        {
            keys = new Key[capacity];
        }
        public SortedArray() : this(10) { }

        public bool IsEmpty { get { return N == 0; } }

        public int Count
        {
            get { { return N; } }
        }

        public int Rank(Key key)
        {
            int left = 0; //左指针
            int right = N - 1;//右指针

            while (left <= right)
            {
                int mid = left + (right - left) / 2;//中间指针

                //二分查找核心算法 
                if (key.CompareTo(keys[mid])<0)
                {
                    right = mid - 1;
                }
                else if (key.CompareTo ( keys[mid])>0)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }

            }
            //如果没找到值返回Left的下标
            return left;
        }

        public void Add(Key key)
        {
       
            //寻找插入位置 （索引位置）
            int index = Rank(key);

            if (N == keys.Length)
            {
                ResetCapacity(keys.Length * 2);
            }
            //判断插入位置的合法性和 去重
            if (index < N && keys[index].CompareTo(key) == 0)
                return;

            for (int i = N-1; index<=i; i--)
            {
                keys[i + 1] = keys[i];
            }
            keys[index] = key;
            N++;
        }
        /// <summary>
        /// 寻找最小值
        /// </summary>

        public Key Min()
        {
            if (IsEmpty)
                throw new AggregateException("数组为空");

            return keys[0];

        }
        /// <summary>
        /// 寻找最大值
        /// </summary>
        public Key Max()
        {
            if(IsEmpty)
                throw new AggregateException("数组为空");

            return keys[N-1];
        }

        public bool Contain(Key key)
        {
            if (Rank(key).Equals(key))
                return true;
            else
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
        public Key Floor(Key key)
        {
            int i = Rank(key);
            if (i == 0)
                throw new AggregateException("不存在小于或者等于" + key + "的值");

            if (i < N && keys[i].CompareTo(key) == 0)
            {
                return keys[i];
            }
            else
                return keys[i - 1];

        }
        /// <summary>
        /// 按索引位置取值
        /// </summary>

        public Key Select(int i)
        {
            if (i >= 0 && i < N)
                return keys[i];
            else
                throw new AggregateException("超出索引");
        }
        public Key Ceiling(Key key)
        {
            int i = Rank(key);
            if (i == N)
            {
                throw new AggregateException("不存在大于或者等于" + key + "的值");
            }
            return keys[i];
        }
        /// <summary>
        /// 删除方法
        /// </summary>
        public void Remove(Key key)
        {
            int index = Rank(key);
     

            if ( IsEmpty)
                return;

            if (index == N || keys[index].CompareTo(key) != 0)
                return;

            for (int i = index; i<=N-1 ; i++)
            {
                keys[i] = keys[i +1];
            }
            N--;
            keys[N] = default(Key);

            if (N < keys.Length / 4)
            {
                ResetCapacity(keys.Length / 2);
            }
        }
        /// <summary>
        /// 自动扩容
        /// </summary>
        /// <param name="capacity"></param>
        private void ResetCapacity(int capacity)
        {
            Key[] NewKeys = new Key[capacity];

            for (int i = 0; i <N; i++)
            {
                NewKeys[i] = keys[i];
            }
            keys = NewKeys;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(keys[i]);
                if (i != N - 1)
                {
                    res.Append(",");
                }

            }
            res.Append("]");
            return res.ToString();
        }



    }
}
