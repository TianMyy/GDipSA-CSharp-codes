using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._05_Sort
{
    class StraightInsertion
    {
        static void Main()
        {
            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };
            InsertSort(data);
            foreach(var temp in data)
            {
                Console.Write(temp + "\t");
            }
        }

        static void InsertSort(int[] dataArray)
        {
            for(int i = 1; i < dataArray.Length; i++)
            {
                int iValue = dataArray[i];
                bool isInsert = false;
                //compare element with index i with former elements, if greater then remain, if less then move
                for (int j = i-1; j >= 0; j--)
                {
                    if(dataArray[j] > iValue)
                    {
                        dataArray[j + 1] = dataArray[j];
                    }
                    else
                    {
                        dataArray[j + 1] = iValue;
                        isInsert = true;
                        break;
                    }
                }
                if(isInsert == false)
                {
                    dataArray[0] = iValue;
                }
            }
        }
    }
}
