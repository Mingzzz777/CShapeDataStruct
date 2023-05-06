using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    interface IStack<T>
    {
        public int Count { get; }

        public bool IsEmpty { get; }

        public T Pop();

        public void Push(T value);

        public T Cheek();

    }
}
