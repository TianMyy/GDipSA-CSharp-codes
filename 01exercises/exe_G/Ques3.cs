using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_G
{
    class Ques3
    {
        static void Main()
        {
            Console.Write("How many students: ");
            int stu = int.Parse(Console.ReadLine());
            Console.Write("How many subjects: ");
            int sub = int.Parse(Console.ReadLine());
            double[,] grade = new double[stu, sub];
            double[] total = new double[stu];

            for (int i = 0; i < stu; i++)
            {
                Console.WriteLine("Marks of student{0}", i + 1);

                for (int j = 0; j < sub; j++)
                {
                    Console.Write("subject{0}: ", j + 1);
                    grade[i, j] = double.Parse(Console.ReadLine());
                    total[i] += grade[i, j];
                }
                Console.WriteLine("The total marks of student{0} is {1}", i + 1, total[i]);
            }

            double[] subtotal = new double[sub];
            double[] avgsub = new double[sub];
            double[] stand = new double[sub];
            for (int i = 0; i < sub; i++)
            {
                for (int j = 0; j < stu; j++)
                {
                    subtotal[i] += grade[j,i];
                    avgsub[i] = subtotal[i] / stu;
                    stand[i] += Math.Pow(grade[j,i] - avgsub[i], 2);
                    stand[i] = Math.Sqrt(stand[i] / stu);
                }
                Console.WriteLine("The average of subject{0} is {1}", i + 1, avgsub[i]);
                Console.WriteLine("The standard deviation of subject{0} is {1}", i + 1, stand[i]);
            }

            double sum = 0;
            for (int i = 0; i < stu; i++)
            {
                sum += total[i];
            }
            double avg = sum / (stu * sub);
            Console.WriteLine("The average of whole class is {0}", avg);
        }
    }
}



        //for (int j = 0; j < sub; j++)
        //{
        //    for (int i = 0; i < stu; i++)
        //    {
        //        subtotal[j] += grade[i, j];
        //    }
        //    avgsub[j] = subtotal[j] / stu;
        //    for (int i = 0; i < stu; i++)
        //    {
        //        stand[j] += Math.Pow(grade[i, j] - avgsub[j], 2);
        //    }
        //    stand[j] = Math.Sqrt(stand[j] / stu);
        //    Console.WriteLine("The average of subject{0} is {1}", j + 1, avgsub[j]);
        //    Console.WriteLine("The standard deviation of subject{0} is {1}", j + 1, stand[j]);
        //}


//namespace MyExerciseEFGH.Exercise_G
//{
//    class Ques3
//    {
//        static void Main()
//        {
//            //make the program can be execute with any amout of students or subjects.
//            Console.Write("How many students: ");
//            int stu = int.Parse(Console.ReadLine());
//            Console.Write("How many subjects: ");
//            int sub = int.Parse(Console.ReadLine());
//            double[,] grade = new double[stu, sub];
//            double[] total = new double[stu];

//            //---3a)
//            for (int i = 0; i < stu; i++)
//            {
//                Console.WriteLine("These are the marks of student {0}: ", i + 1);
//                for (int j = 0; j < sub; j++)
//                {
//                    Console.Write("Subject{0}: ", j + 1);
//                    grade[i, j] = double.Parse(Console.ReadLine());
//                    total[i] += grade[i, j];
//                }
//                Console.WriteLine("Total of student{0} is {1}", i + 1, total[i]);
//            }
//            Console.WriteLine("--------------------------------------");

//            //---3b)
//            double[] subtotal = new double[sub];
//            double[] avgsub = new double[sub];
//            double[] stand = new double[sub];
//            for (int i = 0; i < sub; i++)
//            {
//                for (int j = 0; j < stu; j++)
//                {
//                    subtotal[i] += grade[i, j];
//                    avgsub[i] = subtotal[i] / stu;
//                    stand[i] += Math.Pow(grade[i, j] - avgsub[i], 2);
//                }
//                Console.WriteLine("The average of subject{0} is {1}", i + 1, avgsub[i]);
//                Console.WriteLine("The standard deviation of subject{0} is {1}", i + 1, Math.Sqrt(stand[i] / stu));
//            }
//            Console.WriteLine("--------------------------------------");

//            //---3c)
//            double sum = 0;
//            for (int i = 0; i < stu; i++)
//                sum += total[i];
//            double avg = sum / (stu * sub);
//            Console.WriteLine("The average of whole class is {0}", avg);
//            Console.WriteLine("--------------------------------------");
//        }
//    }
//}
