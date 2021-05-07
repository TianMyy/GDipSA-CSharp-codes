using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._01_IntegerList
{
    class List
    {
        int[] number;
        public List(int[] number)
        {
            this.number = number;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }
        public bool isExist(int x)
        {
            foreach (int ele in number)
            {
                if (ele == x)
                    return true;
            }
            return false;
        }
        public bool Duplicate()
        {
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (number[i] == number[j] && i != j)
                        return true;
                }
            }
            return false;
        }
    }
}
