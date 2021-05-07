using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_G
{
    class Ques1
    {
        static void Main()
        {
            int[] sales = new int[12];
            double total = 0;
            for(int i = 0;i < sales.Length; i++)
            {
                Console.Write("Sale of month {0}: ",i+1);
                sales[i] = int.Parse(Console.ReadLine());
                total += sales[i];
            }

            int max = sales[0];
            int min = sales[0];
            int m = 0;
            int n = 0;
            for (int i = 0; i < sales.Length; i++)
            {
                if (max < sales[i])
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
            Console.WriteLine("Maximum sale is month {0},it is {1}", m+1, max);
            Console.WriteLine("Minimum sale is month {0},it is {1}", n+1, min);
            double avg = total / 12;
            Console.WriteLine("The average monthly sales for the year is {0}",avg);
        }
    }
}

//老师的solution
//namespace SolG
//{
//    class G1
//    {
//        static void Main(string[] args)
//        {
//            int[] sales = new int[12];
//            string[] monthNames = new string[]
//                {"January", "February", "March", "April", "May", "June",
//                "July", "August", "September", "October", "November", "December"};
//            for (int n = 0; n < 12; n++)
//            {
//                Console.Write("Enter sales for month {0} ({1}): ", n, monthNames[n]);
//                sales[n] = Convert.ToInt32(Console.ReadLine());
//            }

//            int max = 0;
//            int min = 0;
//            int sum = sales[0];
//            for (int i = 1; i < 12; i++)
//            {
//                if (sales[i] > sales[max])
//                {
//                    max = i;
//                }
//                if (sales[i] < sales[max])
//                {
//                    min = i;
//                }
//                sum += sales[i];
//            }
//            Console.WriteLine("Maximum Sales: {0} ({1})", max, monthNames[max]);
//            Console.WriteLine("Minimum Sales: {0} ({1})", min, monthNames[min]);
//            Console.WriteLine("Average Sales: " + sum / 12.0);
//        }
//    }
//}

