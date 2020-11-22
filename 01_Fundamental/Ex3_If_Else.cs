using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Ex3_If_Else
    {
        static void Main()
        {
            //Ques1
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your gender(M or F): ");
            string gender = Console.ReadLine();
            if (gender == "M" || gender == "m")
                Console.WriteLine("Good Morning Mr.{0}", name);
            if (gender == "F" || gender == "f")
                Console.WriteLine("Good Morning Ms.{0}", name);
            Console.WriteLine();

            //Ques2
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (gender == "M" || gender == "m")
            {
                if (age < 40)
                    Console.WriteLine("Good Morning Mr.{0}", name);
                else
                    Console.WriteLine("Good Morning Uncle {0}", name);
            }
            if (gender == "F" || gender == "f")
            {
                if (age < 40)
                    Console.WriteLine("Good Morning Ms.{0}", name);
                else
                    Console.WriteLine("Good Morning Aunty {0}", name);
            }
            Console.WriteLine();

            //Ques3
            Console.Write("Enter your marks: ");
            int mark = int.Parse(Console.ReadLine());
            string grade = "";
            if (mark < 0 || mark > 100)
                Console.WriteLine("**Error**");
            else
            {
                if (mark >= 80 && mark <= 100)
                    grade = "A";
                if (mark >= 60 && mark < 80)
                    grade = "B";
                if (mark >= 40 && mark < 60)
                    grade = "C";
                if (mark < 40)
                    grade = "F";
                Console.WriteLine("You scored {0} marks wichi is {1} grade", mark, grade);
            }
            Console.WriteLine();

            //Ques4
            Console.Write("Enter your distance in kilometer: ");
            double distance = double.Parse(Console.ReadLine());
            double dis = Math.Round(distance * 10) / 10;
            double fee = 0;
            if (dis <= 0.5)
                fee = 2.40;
            if (dis > 0.5 && dis <= 9)
                fee = 2.4 + 0.04 * (dis - 0.5) * 10;
            if (dis > 9)
                fee = 2.4 + 0.04 * 85 + 0.05 * (dis - 9) * 10;
            Console.WriteLine("Total fee:{0}", fee);
            Console.WriteLine();

            //Ques5
            Console.Write("Enter your three-digit integer: ");
            int input = int.Parse(Console.ReadLine());
            int ge = input % 10;
            int shi = (input / 10) % 10;
            int bai = input / 100;

            int sum = (int)(Math.Pow(ge, 3) + Math.Pow(shi, 3) + Math.Pow(bai, 3));
            if (sum == input)
                Console.WriteLine("True Armstrong Number");
            else
                Console.WriteLine("False");
            Console.WriteLine();
        }
    }
}
