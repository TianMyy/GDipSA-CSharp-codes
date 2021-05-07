using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_H
{
    class Ques4
    {
        static void Main()
        {
            Console.WriteLine(Substitute("institute of system analysis", 'i', 'I'));
        }
        public static string Substitute(string s,char c1,char c2)
        {
            char[] input = s.ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == c1)
                {
                    input[i] = c2;
                }
            }
            return new string(input);
        }
        /*
        public static string Substitute(string s, char c1, char c2)
        {
            // Substitute("abcde", 'a', 'z') = zbcde 
            string newString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                {
                    newString += c2; // newString = newString+c2
                }
                else
                {
                    newString += s[i];
                }
            }
            return newString;
        }
        */
    }
}
