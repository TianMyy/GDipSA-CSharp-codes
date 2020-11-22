using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._01_List
{
    class program1
    {
        static void Main()
        {
            //使用我们自己的顺序表
            SeqList<string> seqList = new SeqList<string>();
            seqList.Add("123");
            seqList.Add("456");
            seqList.Add("789");

            Console.WriteLine(seqList.GetEle(0));
            Console.WriteLine(seqList[0]);

            seqList.Insert("777", 1);
            for (int i = 0; i < seqList.Getlength(); i++)
            {
                Console.Write(seqList[i] + "\t");
            }
            Console.WriteLine();

            seqList.Delete(0);
            for (int i = 0; i < seqList.Getlength(); i++)
            {
                Console.Write(seqList[i] + "\t");
            }
            Console.WriteLine();

            seqList.Clear();
            Console.WriteLine(seqList.Getlength());

        }
    }
}
