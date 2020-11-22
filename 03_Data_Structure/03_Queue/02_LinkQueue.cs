using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._03_Queue
{
    class LinkQueue<T> : IQueueDS<T>
    {
        private T[] data;
        private int count;
        private Node<T> front; //头结点
        private Node<T> rear; //尾结点

        public LinkQueue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            count = 0;
            front = null;
            rear = null;
        }

        public void Enqueue(T item)
        {
            //入队的操作
            Node<T> newNode = new Node<T>(item);
            if (count == 0)
            {
                front = newNode;
                rear = newNode; //如果队内为空的话，新添加的元素就是我们的头结点
                count++;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
                count++;
            }
        }

        public T Dequeue()
        {
            if(count == 0)
            {
                Console.WriteLine("队列为空，无法出队");
                return default(T);
            }
            else if(count == 1)
            {
                T temp = front.Data;
                front = rear = null;
                count--;
                return temp;
            }
            else
            {
                T temp = front.Data;
                front = front.Next;
                count--;
                return temp;
            }
        }

        public T Peek()
        {
            if (front != null)
                return front.Data;
            else
                return default(T);
        }
    }
}
