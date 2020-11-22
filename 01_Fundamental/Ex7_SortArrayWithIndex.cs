using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Ex7_SortArrayWithIndex
    {
        static void Main()
        {
            string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[5] { 63, 29, 75, 82, 55 };
            int[] descend = new int[5] { 0, 1, 2, 3, 4 };
            //Sort by marks
            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int n = i + 1; n < marks.Length; n++)
                {
                    if (marks[descend[i]] < marks[descend[n]])
                    {
                        int temp = descend[i];
                        descend[i] = descend[n];
                        descend[n] = temp;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
                Console.WriteLine("{0}\t{1}", name[descend[i]], marks[descend[i]]);

            Console.WriteLine();

            //Sort by name
            int[] namesAsc = new int[] { 0, 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (String.Compare(name[namesAsc[i]], name[namesAsc[j]], StringComparison.Ordinal) > 0)
                    //String.Compare:compare two sepcific string, 
                    //StringComparison.Ordinal:Compares substrings of two specified String objects 
                    //by evaluating the numeric values of the corresponding Char objects in each substring.
                    {
                        //swap the order 
                        var temp = namesAsc[i];
                        namesAsc[i] = namesAsc[j];
                        namesAsc[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t{1}", name[namesAsc[i]], marks[namesAsc[i]]);
            }
        }
    }
}
