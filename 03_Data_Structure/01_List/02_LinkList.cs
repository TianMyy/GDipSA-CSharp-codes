using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._01_List
{
    class LinkList<T> : IListDS<T>
    {
        //存储头结点
        private Node<T> head;

        public LinkList()
        {
            head = null;
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item); //根据新的数据创建一个新的结点
            //如果头结点为空，那么新的节点就是头结点
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                //如果头结点不为空 新来的节点放到链表的尾部
                //访问链表尾结点
                Node<T> temp = head;
                while (true)
                {
                    if (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    else
                        break;
                }
                temp.Next = newNode;
            }
        }

        public void Insert(T item, int index)
        {
            Node<T> newNode = new Node<T>(item);
            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                preNode.Next = newNode;
                newNode.Next = currentNode;

                //temp.Next = newNode;
                //newNode.Next = temp.Next.Next;
            }
        }

        public T Delete(int index)
        {
            T data = default(T);
            if (index == 0)
            {
                data = head.Data;
                head = head.Next;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> nextNode = temp.Next.Next;
                preNode.Next = nextNode;
                Node<T> currentNode = temp.Next;
                data = currentNode.Data;
            }
            return data;
        }

        public int Getlength()
        {
            if (head == null)
                return 0;
            else
            {
                Node<T> temp = head;
                int count = 1;
                while (true)
                {
                    if (temp.Next != null)
                    {
                        count++;
                        temp = temp.Next;
                    }
                    else
                    {
                        break;
                    }
                }
                return count;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public T this[int index]
        {
            get
            {
                Node<T> temp = head;
                for (int i = 0; i <= index; i++)
                {
                    temp = temp.Next;
                }
                return temp.Data;
            }
        }

        public T GetEle(int index)
        {
            return this[index];
        }

        public int Locate(T value)
        {
            Node<T> temp = head;
            if (temp == null)
                return -1;
            else
            {
                int index = 0;
                while (true)
                {
                    if (temp.Data.Equals(value))
                        return index;
                    else
                    {
                        if (temp.Next != null)
                            temp = temp.Next;
                        else
                            break;
                    }
                }
                return -1;
            }
        }
    }
}
