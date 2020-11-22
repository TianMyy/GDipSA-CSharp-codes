using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._05_Sort
{
    class Select
    {
        static void Main()
        {
            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };
            SelectSort(data);
            foreach(var temp in data)
            {
                Console.Write(temp + " ");
            }
        }

        static void SelectSort(int[] dataArray)
        {
            for(int i = 0; i < dataArray.Length - 1; i++)
            {
                int min = dataArray[i];
                int minIndex = i;
                for (int j = i+1; j < dataArray.Length; j++)
                {
                    if(dataArray[j] < min)
                    {
                        min = dataArray[j];
                        minIndex = j;
                    }
                }
                if(minIndex != i)
                {
                    int temp = dataArray[i];
                    dataArray[i] = dataArray[minIndex];
                    dataArray[minIndex] = temp;
                }
            }
        }
    }
}
