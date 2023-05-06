using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    interface IQueue<T>
    {
        int Count { get; }

        bool IsEmpty { get; }

        void EnQueue(T value);

       T DeQueue();

        T Cheek();
    }
}
