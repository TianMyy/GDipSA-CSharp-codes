using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._03_Queue
{
    class StackAndQueueExample
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            for(int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
                queue.Enqueue(str[i]);
            }

            bool IsInverse = true;
            while(stack.Count > 0)
            {
                if(stack.Pop() != queue.Dequeue())
                {
                    IsInverse = false;
                    break;
                }
            }
            Console.WriteLine("Is inverse string? " + IsInverse);
        }
    }
}
