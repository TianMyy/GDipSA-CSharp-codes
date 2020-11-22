using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Ex9_ModularizationUsingStaticMethod
    {
        static void Main()
        {
            //Ques1
            int input = ReadInteger("Enter your integer: ");
            Console.WriteLine(input);
            Console.WriteLine();

            //Ques2
            Console.Write("How many elements in your array: ");
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            Console.WriteLine("Enter your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            PrintArray(array);
            Console.WriteLine();

            //Ques3
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}\t{1}", i, ReturnHex(i));
            }
            Console.WriteLine();

            //Ques4
            Console.Write("Enter your string: ");
            string str = (Console.ReadLine()).ToLower();
            string outcome = Substitute(str, 's', 'e');
            Console.WriteLine(outcome);
            Console.WriteLine();

            //Ques5
            Console.Write("How long is your array: ");
            int[] arr = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter your array: ");
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.Write("Enter the value you want to assign: ");
            int value = int.Parse(Console.ReadLine());
            SetArray(arr, value);
            Console.WriteLine();

            //Ques6
            int[] A1 = new int[] { 1, 2, 3, 4, 5 };
            PrintArray(A1);

            int[] B1 = ResizeArray(A1, 10);
            PrintArray(B1);

            int[] C1 = ResizeArray(B1, 3);
            PrintArray(C1);
            Console.WriteLine();

            //Ques7
            Console.WriteLine("Prime Number: ");
            for (int i = 5; i < 1000; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine(i);
            }
            Console.WriteLine();

            //Ques8
            int[,] A = new int[,]
                {
                    {1,2,3,4,5 },
                    {6,7,8,9,10 },
                    {11,12,13,14,15 },
                    {16,17,18,19,20 }
                };
            PrintMatrix("A", A);

            int[,] B = new int[,]
                {
                    {1,2 },
                    {3,4 },
                    {5,6 },
                    {7,8 },
                    {9,10 }
                };
            PrintMatrix("B", B);

            int[,] C = MatrixMultiply(A, B);
            PrintMatrix("C", C);
            Console.WriteLine();

            //Ques9
            double[] A2 = new double[] { 1.5, 2.5, 3.5, 4.5 };
            PrintArr("A", A2);

            DoubleOps sqrt = Sqrt;
            PrintArr("Sqrt", ProcessArray(A2, sqrt));

            DoubleOps square = Square;
            PrintArr("Square", ProcessArray(A2, square));
        }

        //Ques1
        public static int ReadInteger(string s)
        {
            Console.Write(s);
            int output = 0;
            bool isInteger = false;
            while (isInteger == false)
            {
                isInteger = int.TryParse(Console.ReadLine(), out output);
                if (isInteger == false)
                    Console.Write("Your enter is not an integer.\nTry again: ");
            }
            return output;
        }

        //Ques2
        public static void PrintArray(int[] arr)
        {
            Console.Write("Your array is:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        //Ques3
        public static string ReturnHex(int x)
        {
            string hex = "";
            string a = "";
            string b = "";
            string[] str = new string[6] { "A", "B", "C", "D", "E", "F" };
            if (x >= 0 && x <= 9)
                hex = x.ToString();
            if (x > 9 && x <= 15)
                hex = str[x - 10];
            if (x >= 16)
            {
                a = (x / 16).ToString();
                if ((x % 16) >= 0 && (x % 16) <= 9)
                    b = (x % 16).ToString();
                if ((x % 16) > 9 && (x % 16) <= 15)
                    b = str[(x % 16) - 10];
                hex = a + b;
            }
            return hex;
        }

        //Ques4
        public static string Substitute(string s, char c1, char c2)
        {
            string ss = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                    ss = s.Replace(s[i], c2);
            }
            return ss;
        }

        //Ques5
        public static void SetArray(int[] arr, int value)
        {
            Console.Write("New array after assign: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += value;
                Console.Write(arr[i] + " ");
            }
        }

        //Ques6
        public static int[] ResizeArray(int[] arr, int newsize)
        {
            int[] newarr = new int[newsize];
            if (newsize > arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                    newarr[i] = arr[i];
            }
            else
            {
                for (int i = 0; i < newsize; i++)
                    newarr[i] = arr[i];
            }
            return newarr;
        }

        //Ques7
        public static Boolean IsPrime(int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            if (count == 1)
                return true;
            else
                return false;
        }

        //Ques8
        public static int[,] MatrixMultiply(int[,] a, int[,] b)
        {
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        r[i, j] = a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
        public static void PrintMatrix(string s, int[,] a)
        {
            Console.WriteLine("--------{0}", s);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Ques9    
        delegate double DoubleOps(double x);
        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] newarray = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newarray[i] = ops(arr[i]);
            }
            return newarray;
        }
        static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        static double Square(double x)
        {
            return Math.Pow(x, 2);
        }
        static void PrintArr(string s, double[] a)
        {
            Console.WriteLine("--------{0}", s);
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
