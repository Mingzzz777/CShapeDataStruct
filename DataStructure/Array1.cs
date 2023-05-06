using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Array1<T>
    { 
        private T [] data;//数组
        private int N; //数组个数
        /// <summary>
        /// 构造函数 构造函数是一种特殊的函数，用来在对象实例化的时候初始化对象的成员变量
        /// </summary>
        public Array1( int capacity) //已知容量
        {
            data = new T[capacity];
            N = 0;
        }

        public Array1()   //未知容量
        {
            data = new T[10];
            N = 0;
        }

        public int Capacity //获取数组容量
        {
            get { return data.Length; }
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
        ///         数组元素添加方法
        /// </summary>
        public void Add(int index,T e)
        {
            if (index < 0 || index > data.Length)
            {
                throw new ArgumentException("超出数组索引");
            }

            if (N == data.Length)
            {
                SetCapacity(data.Length * 2);
            }

            for (int i = N-1; i >= index; i--)
            {
                data[i + 1] = data[i];
               
            }
            data[index] = e;
            N++;
        }
        /// <summary>
        ///  向数组末尾添加元素
        /// </summary>
        public void AddLast(T e)
        {
            Add(N, e);
        }
        /// <summary>
        ///  向数组首位添加元素
        /// </summary>
        public void AddFirst(T e)
        {
            Add(0, e);
        }
        /// <summary>
        ///  数组的扩容（缩容）方法
        /// </summary>
        public void SetCapacity(int NewCapacity)
        {
            T[] newData = new T[NewCapacity];
            for (int i = 0; i < N; i++)
            {
                newData[i] = data[i];
            }
            //覆盖旧数组
            data = newData;
        }

        /// <summary>
        /// 索引数组元素信息
        /// </summary>
        public T Get(int index)
        {
            if (index < 0 || index > data.Length)
            {
                throw new ArgumentException("超出数组索引");
            }
            return data[index];
        }
        /// <summary>
        /// 索引数组末尾元素
        /// </summary>
        public T GetFirst()
        {
           return Get(0);
        }
        /// <summary>
        /// 索引数组首位元素
        /// </summary>
        public T GetLast()
        {
            return Get(N - 1);
        }
        /// <summary>
        /// 修改数组元素
        /// </summary>
        public void SetValue( int index,int value)
        {
            if (index < 0 || index > data.Length)
            {
                throw new ArgumentException("超出数组索引");
            }
            data[index].Equals(value);
        }
        /// <summary>
        ///       查询数组是否包含 value 这个值
        /// </summary>
        public bool Contain(int value)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 索引数组元素 value 下标
        /// </summary>
       
        public int IndexOf(int value)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// 按照数组排序 删除数组中的某个元素
        /// </summary>
        public T  RemoveAt(int index)
        {
            T del = data[index];

            for (int i = index; i <N-1; i++)
            {
                data[i] = data[i + 1];
            }
            N--;
            data[N] = default(T);
            if (N <=data.Length / 4)
            {
                SetCapacity(data.Length / 2);
            }

            return del;
        }
        /// <summary>
        ///  删除指定数值的数组元素
        /// </summary>
        public void RemoveOfValue(int value)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(value))
                {
                    RemoveAt(i);
                }
            }
        }
        public T RemobeLast()
        {
          return  RemoveAt(N - 1);
        }

        public T RemoveFirst()
        {
           return RemoveAt(0);
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Array1: count{0} capacity{1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
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
