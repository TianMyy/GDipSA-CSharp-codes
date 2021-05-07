using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1026
{
    class Ques3
    {
        static void Main()
        {
            string[] words = new string[]
            {
                "good","morning","class","have","a","good","class","and","have","fun"
            };
            Display(words);
        }
        public static void Display(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Substring(0, 1) == "a" || arr[i].Length > 6)
                    Console.WriteLine(arr[i]);
            }
            //foreach(string ele in arr)
            //{
            //    if (ele[0] == 'a' || ele.Length > 6)
            //        Console.WriteLine(ele);
            //}
        }
    }
}
