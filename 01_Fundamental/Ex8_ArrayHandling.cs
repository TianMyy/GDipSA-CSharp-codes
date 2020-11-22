using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Ex8_ArrayHandling
    {
        static void Main()
        {
            //Ques1
            Console.WriteLine("Enter sales for 12 months: ");
            int[] sales = new int[12];
            int total = 0;
            for (int i = 0; i < 12; i++)
            {
                sales[i] = int.Parse(Console.ReadLine());
                total += sales[i];
            }
            int max = sales[0];
            int min = sales[0];
            int m = 0;
            int n = 0;
            for (int i = 0; i < 12; i++)
            {
                if (sales[i] > max)
                {
                    max = sales[i];
                    m++;
                }
                if (min > sales[i])
                {
                    min = sales[i];
                    n++;
                }
            }
            Console.WriteLine("The max sales is {0} in {1} month.\nThe min sales is {2} in {3} month.\nAverage for the year is {4}", sales[m], m + 1, sales[n], n + 1, total / 12);
            Console.WriteLine();

            //Ques2
            int[] arr = new int[6] { 4, 7, 1, 0, 9, 2 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                for (int a = 0; a < arr.Length; a++)
                    Console.Write("{0}\t", arr[a]);
                Console.WriteLine();
            }
            Console.WriteLine();

            //Ques3
            Console.Write("How many students: ");
            int stu = int.Parse(Console.ReadLine());
            Console.Write("How mmany subjects: ");
            int sub = int.Parse(Console.ReadLine());
            int[,] grade = new int[stu, sub];
            int[] marks = new int[stu];
            for (int i = 0; i < stu; i++)
            {
                Console.WriteLine("Student {0}", i + 1);
                for (int j = 0; j < sub; j++)
                {
                    Console.Write("Subject{0}: ", j + 1);
                    grade[i, j] = int.Parse(Console.ReadLine());
                    marks[i] += grade[i, j];
                }
                Console.WriteLine("The total marks for student{0}:{1}", i + 1, marks[i]);
                Console.WriteLine("Average for student{0}:{1}", i + 1, marks[i] / sub);
            }
            double[] subtotal = new double[sub];
            double total2 = 0;
            double[] ave = new double[sub];
            double[] variance = new double[sub];
            for (int i = 0; i < sub; i++)
            {
                for (int j = 0; j < stu; j++)
                {
                    subtotal[i] += grade[j, i];
                    ave[i] = subtotal[i] / stu;
                    variance[i] += Math.Pow(grade[j, i] - ave[i], 2);
                }
                Console.WriteLine("Average for subject{0}:{1:0.#####}", i + 1, ave[i]);
                Console.WriteLine("Deviation for subject{0}:{1}", i + 1, Math.Sqrt(variance[i]));
                total2 += subtotal[i];
            }
            Console.WriteLine("Average for whole class:{0}", total2 / (stu * sub));
            Console.WriteLine();
        }
    }
}
