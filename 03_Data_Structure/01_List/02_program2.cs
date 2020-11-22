using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._01_List
{
    class program2
    {
        static void Main()
        {
            LinkList<string> linkList = new LinkList<string>();
            linkList.Add("123");
            linkList.Add("456");
            linkList.Add("789");

            Console.WriteLine(linkList.GetEle(0));
            Console.WriteLine(linkList[0]);

            linkList.Insert("777", 1);
            for (int i = 0; i < linkList.Getlength(); i++)
            {
                Console.Write(linkList[i] + "\t");
            }
            Console.WriteLine();

            linkList.Delete(0);
            for (int i = 0; i < linkList.Getlength(); i++)
            {
                Console.Write(linkList[i] + "\t");
            }
            Console.WriteLine();

            linkList.Clear();
            Console.WriteLine(linkList.Getlength());

        }
    }
}
