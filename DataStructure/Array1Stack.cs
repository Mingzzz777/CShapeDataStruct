using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 数组栈
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Array1Stack<T> : IStack<T>
    {
        private Array1<T> array;

        public int Count { get { return array.Count; } }

        public bool IsEmpty { get {return array.IsEmpty; } }
        /// <summary>
        /// 构造函数 初始化变量
        /// </summary>
        public Array1Stack(int capacity)
        {
            array = new Array1<T>(capacity);
        }

        public Array1Stack()
        {
            array = new Array1<T>();
        }
        /// <summary>
        /// 出栈
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            return array.RemobeLast();
        }
        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            array.AddLast(value);
        }
        /// <summary>
        /// 检查栈顶元素
        /// </summary>
        /// <returns></returns>
        public T Cheek()
        {
           return array.GetLast();
        }

        public override string ToString()
        {
            return "Stack :top" + array.ToString() ;
        }
    }
    
}
