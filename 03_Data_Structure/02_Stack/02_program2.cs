using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._02_Stack
{
    class program2
    {
        static void Main()
        {
            //1.使用BCL中的Stack<T>
            //Stack<char> stack = new Stack<char>();
            //2.使用我们自己的栈
            //IStackDS<char> stack = new SeqStack<char>(30);
            //3.使用我们自己的链栈
            IStackDS<char> stack = new LinkStack<char>();
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');//栈顶数据
            Console.WriteLine("after pushing a b c:" + stack.Count);

            char temp = stack.Pop();//取得栈顶数据，并删除
            Console.WriteLine("after poping data:" + temp);
            Console.WriteLine("after poping:" + stack.Count);

            char temp2 = stack.Peek(); //取得栈顶数据，不删除
            Console.WriteLine("after peeking data:" + temp2);
            Console.WriteLine("after peeking:" + stack.Count);

            stack.Clear();
            Console.WriteLine("after clearing:" + stack.Count);
        }
    }
}
