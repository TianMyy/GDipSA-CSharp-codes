using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_H
{
    class Ques9
    {
        delegate double DoubleOps(double x);
        static void Main()
        {
            double[] A = new double[] { 1.5, 2.5, 3.5, 4.5 };
            Printarr("A", A);

            DoubleOps sqrt = Sqrt;
            Printarr("Sqrt",ProcessArray(A, sqrt));

            DoubleOps square = Square;
            Printarr("Square",ProcessArray(A, square));
        }
        static double[] ProcessArray(double[] arr,DoubleOps ops)
        {
            double[] output = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                output[i] = ops(arr[i]);
            }
            return output;
        }
        static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        static double Square(double x)
        {
            return Math.Pow(x,2);
        }
        static void Printarr(string name,double[] arr)
        {
            Console.WriteLine("----{0})",name);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}\t",arr[i]);
            }
            Console.WriteLine();
        }
    }
}
