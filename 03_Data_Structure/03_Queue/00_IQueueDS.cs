using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._03_Queue
{
    interface IQueueDS<T>
    {
        int Count { get; }
        int GetLength();
        bool IsEmpty();
        void Clear();
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
}
