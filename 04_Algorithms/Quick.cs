using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._05_Sort
{
    class Quick
    {
        static void Main()
        {
            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };
            QuickSort(data, 0, data.Length - 1);
            foreach(var temp in data)
            {
                Console.Write(temp + " ");
            }
        }

        /// <summary>
        /// sort the number from index(left) to index(right) in the array
        /// </summary>
        /// <param name="dataArray"></param>
        static void QuickSort(int[] dataArray,int left, int right) 
        {
            if(left < right)
            {
                int x = dataArray[left];//基准数，把比它小的放在左边，大的放在右边
                int i = left;
                int j = right;//用来做循环的标志位

                while(true && i < j) //当i = j的时候说明我们找到了一个中间位置，这个中间位置就是基准数应该在的位置
                {
                    //从后往前比较（从右向左）找一个比x小（或者=）的数字，放在我们的坑里，坑位于i的位置
                    while (true && i < j)
                    {
                        if (dataArray[j] <= x)
                        {
                            dataArray[i] = dataArray[j];
                            break;
                        }
                        else
                        {
                            j--;//向左移动到下一个数字，继续做比较
                        }
                    }

                    //从前往后（从左向右）比较，找一个比x大的数字，放在我们的坑里面，现在的坑位于j的位置
                    while (true && i < j)
                    {
                        if (dataArray[i] > x)
                        {
                            dataArray[j] = dataArray[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                //跳出循环，现在i == j， i是中间位置
                dataArray[i] = x; //left -i- right

                QuickSort(dataArray, left, i - 1);
                QuickSort(dataArray, i + 1, right);
            }
        }
    }
}
