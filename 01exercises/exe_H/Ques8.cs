using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_H
{
    class Ques8
    {
        static void Main()
        {
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
        }
        public static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            int[,] R = new int[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        R[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return R;
        }
        public static void PrintMatrix(string name,int[,]A)
        {
            Console.WriteLine("----{0})",name);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("{0}\t",A[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
