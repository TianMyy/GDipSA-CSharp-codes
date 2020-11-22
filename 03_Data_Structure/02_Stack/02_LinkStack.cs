using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._02_Stack
{
    class LinkStack<T> : IStackDS<T>
    {
        private Node<T> top; //栈顶元素结点
        private int count = 0; //栈中元素的个数

        public int Count //取得栈中元素的个数
        {
            get { return count; }
        }

        public int GetLength() //取得栈中元素的个数
        {
            return count;
        }

        public bool IsEmpty() //判断栈中是否有数据
        {
            return count == 0;
        }

        public void Clear() //清空栈中所有的数据
        {
            count = 0;
            top = null;
        }

        public void Push(T item)
        {
            //把新添加的元素作为头结点，也就是栈顶元素
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public T Pop()
        {
            //出栈 取得栈顶元素并删除
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        public T Peek()
        {
            //取得栈顶中的数据 不删除栈顶
            return top.Data;
        }
    }
}
