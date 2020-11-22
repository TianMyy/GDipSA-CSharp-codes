using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Ex6_StringHandling
    {
        static void Main()
        {
            //Ques1
            Console.Write("Enter your phrase: ");
            string ss = Console.ReadLine();
            string input = ss.ToLower();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string s = input.Substring(i, 1);
                if (s == "a" || s == "e" || s == "i" || s == "o" || s == "u")
                    count++;
            }
            Console.WriteLine("There are {0} vowels", count);
            int counta = 0;
            int counte = 0;
            int counti = 0;
            int counto = 0;
            int countu = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string str = input.Substring(i, 1);
                if (str == "a")
                    counta++;
                if (str == "e")
                    counte++;
                if (str == "i")
                    counti++;
                if (str == "o")
                    counto++;
                if (str == "u")
                    countu++;
            }
            Console.WriteLine("Number of a is {0}", counta);
            Console.WriteLine("Number of e is {0}", counte);
            Console.WriteLine("Number of i is {0}", counti);
            Console.WriteLine("Number of o is {0}", counto);
            Console.WriteLine("Number of u is {0}", countu);
            Console.WriteLine();

            //Ques2&Ques3
            Console.Write("Enter your string: ");
            string a = Console.ReadLine();
            string b = a.ToUpper();
            string c = b.Replace(" ", "");
            string d = c.Replace(".", "");
            string outcome = "";
            for (int i = (d.Length - 1); i >= 0; i--)
            {
                outcome += d[i];
            }
            if (outcome == d)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
            Console.WriteLine();

            //Ques4
            Console.Write("Enter your phrase: ");
            string p = Console.ReadLine();
            string[] arr = p.Split(' ');
            string output = "";
            foreach (string ele in arr)
            {
                output += ele.Substring(0, 1).ToUpper() + ele.Substring(1) + " ";
            }
            Console.WriteLine(output);
            Console.WriteLine();

            //Ques5
            Console.Write("Enter your matriculation number: ");
            string str2 = Console.ReadLine();
            string num = str2.ToUpper();
            int sum = 0;
            if (num.Length == 7)
            {
                int j = 6;
                for (int i = 1; i < (num.Length - 1); i++)
                {
                    sum += int.Parse(num.Substring(i, 1)) * j;
                    j--;
                }
                int remain = sum % 5;
                string check = "";
                if (remain == 0)
                    check = "O";
                if (remain == 1)
                    check = "P";
                if (remain == 2)
                    check = "Q";
                if (remain == 3)
                    check = "R";
                if (remain == 4)
                    check = "S";

                if (check == num.Substring(6, 1))
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
            else
                Console.WriteLine("Invalid");
            Console.WriteLine();
        }
    }
}
