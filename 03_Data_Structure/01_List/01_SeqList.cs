using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._01_List
{
    class SeqList<T> : IListDS<T>
    {
        /// <summary>
        /// 顺序表实现方式
        /// <param name="index"></param>
        /// <returns></returns>

        private T[] data;//用来存储数据
        private int count = 0;//表示存了多少个数据

        public SeqList(int size) //size就是最大容量
        {
            data = new T[size];
            count = 0;
        }
        public SeqList() : this(10)//默认构造函数容量为10
        {

        }

        public void Add(T item)
        {
            if (count == data.Length)//当前顺序表存满了
                Console.WriteLine("当前顺序表已经存满，不允许再存入");
            else
            {
                data[count] = item;
                count++;
            }
        }

        //取得数据的个数
        public int Getlength()
        {
            return count;
        }

        public T GetEle(int index)
        {
            if (index >= 0 && index <= count - 1) //判断这个索引存不存在
                return data[index];
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);
            }
        }

        public void Clear()
        {
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Insert(T item, int index)
        {
            for (int i = count - 1; i >= index; i--)
            {
                data[i + 1] = data[i]; //从后往前遍历，将所有值往后移动
            }
            data[index] = item;
            count++;
        }

        public T Delete(int index)
        {
            T temp = data[index];
            for (int i = index + 1; i < count; i++)
            {
                data[i - 1] = data[i]; //从前往后遍历，将所有值往前移动
            }
            count--;
            return temp;
        }

        public T this[int index]
        {
            get { return GetEle(index); }
        }

        public int Locate(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value)) //判断是否相等调用.Equals()
                {
                    return i;
                }
            }
            return -1; //没有找到相等元素直接返回-1
        }
    }
}
