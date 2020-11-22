using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._01_List
{
    interface IListDS<T>
    {
        int Getlength();
        void Clear();
        bool IsEmpty();
        void Add(T item);
        void Insert(T item, int index);
        T Delete(int index);
        T this[int index] { get; }
        T GetEle(int index); //根据索引得到值
        int Locate(T value); //根据值得到索引

    }
}
