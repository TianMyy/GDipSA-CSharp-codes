using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Ex2_ExpressionAndMath
    {
        static void Main()
        {
            //Ques1
            Console.Write("Enter your double precision number: ");
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine("Output:{0}", Math.Sqrt(input));
            Console.WriteLine();
            //Ques2
            Console.WriteLine("Output:{0:0.000}", Math.Sqrt(input));
            Console.WriteLine();

            //Ques3
            Console.Write("Enter your salary: ");
            double input3 = double.Parse(Console.ReadLine());
            double salary = input3 + input3 * 0.1 + input3 * 0.03;
            Console.WriteLine("Salary:${0:#,0.00}", salary);
            Console.WriteLine();

            //Ques4
            Console.Write("Enter the temperature in Centigrade: ");
            double centi = double.Parse(Console.ReadLine());
            double fahren = (centi * 1.8) + 32;
            Console.WriteLine("Fahrenheit:{0}", fahren);
            Console.WriteLine();

            //Ques5
            Console.Write("Enter the value of X: ");
            double x = double.Parse(Console.ReadLine());
            double y = 5 * (Math.Pow(x, 2)) - 4 * x + 3;
            Console.WriteLine(y);
            Console.WriteLine();

            //Ques6
            double[] values = new double[4];
            Console.WriteLine("Enter the value of X1,Y1,X2,Y2 in order: ");
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = double.Parse(Console.ReadLine());
            }
            double valuex = values[2] - values[0];
            double valuey = values[3] - values[1];
            double distance = Math.Sqrt(Math.Pow(valuex, 2) + Math.Pow(valuey, 2));
            Console.WriteLine("Output:{0}", distance);
            Console.WriteLine();

            //Ques7
            Console.Write("Enter your distance: ");
            double kilo = double.Parse(Console.ReadLine());
            double fee = 2.40 + kilo * 0.4;
            Console.WriteLine("Total fee:{0}", fee);
            Console.WriteLine();
            //Ques8
            Console.WriteLine("Total fee:{0:0.00}", Math.Round(fee, 1));
            Console.WriteLine();
            //Ques9
            double end = Math.Ceiling(fee * 10) / 10;
            Console.WriteLine("Total fee:{0}", end);
            Console.WriteLine();

            //Ques10
            double[] sides = new double[3];
            Console.WriteLine("Enter value of side1,side2,side3: ");
            for (int i = 0; i < sides.Length; i++)
            {
                sides[i] = double.Parse(Console.ReadLine());
            }
            double side1 = sides[0];
            double side2 = sides[1];
            double side3 = sides[2];
            double s = (side1 + side2 + side3) / 2;

            if (side1 > 0 && side2 > 0 && side3 > 0 &&
                side1 + side2 > side3 &&
                side1 + side3 > side2 &&
                side2 + side3 > side1)
            {
                double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
                Console.WriteLine("Output:{0}", area);
            }
            else
            {
                Console.WriteLine("NaN");
            }
            Console.WriteLine();
        }
    }
}
