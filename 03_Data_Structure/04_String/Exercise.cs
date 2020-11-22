using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._04_String
{
    class Exercise
    {
        static void Main()
        {
            StringDS s = new StringDS("I am a teacher");
            StringDS i = new StringDS("excellent");
            StringDS r = new StringDS("student");
            Console.WriteLine(s.GetLength());
            Console.WriteLine(i.GetLength());
            Console.WriteLine(r.GetLength());

            StringDS s2 = s.SubString(8, 4);
            Console.WriteLine(s2.ToString());
            StringDS i2 = i.SubString(2, 1);
            Console.WriteLine(i2.ToString());
            StringDS r2 = r.SubString(3, 6);
            Console.WriteLine(r2.ToString());

            Console.WriteLine(s.IndexOf(new StringDS("tea")));
            Console.WriteLine(i.IndexOf(new StringDS("cell")));
        }
    }
}
