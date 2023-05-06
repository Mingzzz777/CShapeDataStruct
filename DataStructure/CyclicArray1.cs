using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 循环数组
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class CyclicArray1<T>
    {
        T[] data;
        int Frist;
        int Last;
        int N;
       public CyclicArray1(int capacity)
        {
            data = new T[capacity];
            Frist = 0;
            Last = 0;
            N = 0;
        }
        public CyclicArray1() : this(10) { }

        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }

        public void AddLast(T value)
        {
            //数组扩容
            if (N == data.Length)
                ResetCapacity(data.Length * 2);

           
            data[Last] = value;
            //添加 指针往后位移
            Last = (Last + 1) % data.Length;
            N++;
        }
        public T RemoveFirst()
        {
            if (IsEmpty)
                throw new ArgumentException("超出数组索引");
            //数组缩容
            if (data.Length / 4 > N)
            {
                ResetCapacity(data.Length / 2);
            }

            T del = data[Frist];
            data[Frist] = default;
            //删除 指针往后位移
            Frist = (Frist + 1) % data.Length;
            N--;
            return del;
        }

        public T GetFrist()
        {
            return data[Frist];
        }
        /// <summary>
        ///  数组扩容（缩容）
        /// </summary>
        /// <param name="capacity"></param>
        public void ResetCapacity(int capacity)
        {
          T [] dataNew=new T [capacity];
            for (int i = 0; i < data.Length; i++)
            {
                //重新开辟数组赋值
                dataNew[i] = data[(Frist + i) % data.Length];
            }
            data = dataNew;
            Frist = 0;
            Last = N;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            res.Append(string.Format("Count={0}  Length={1}\n", N, data.Length));
            for (int i = 0; i < N; i++)
            {
                //  res.Append(data[(Frist+i)%data.Length] + "-");
                res.Append(data[i] + "-");
            }
            return res.ToString();
        }
    }
}
