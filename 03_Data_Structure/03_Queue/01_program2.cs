using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._03_Queue
{
    class program2
    {
        static void Main()
        {
            //1.使用BCL中的队列
            //Queue<int> queue = new Queue<int>();
            //2.使用我们的顺序队列
            IQueueDS<int> queue = new SeqQueue<int>();

            //入队 添加数据
            queue.Enqueue(23); //队首
            queue.Enqueue(45);
            queue.Enqueue(67);
            queue.Enqueue(89); //队尾
            Console.WriteLine("添加了 23 45 67 89之后队列的大小为:" + queue.Count);

            //出队(取得队首数据并删除)
            int i = queue.Dequeue();
            Console.WriteLine("取得队首的数据为：" + i);
            Console.WriteLine("出队之后，队列的大小为:" + queue.Count);

            int j = queue.Peek();
            Console.WriteLine("peek得到的结果是:" + j);
            Console.WriteLine("peek之后队列的大小为:" + queue.Count);

            queue.Clear();
            Console.WriteLine("Clear之后队列的大小为:" + queue.Count);

        }
    }
}
