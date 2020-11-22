using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._04_String
{
    class StringDS
    {
        private char[] data; //use to store char in string

        public StringDS(char[] array)
        {
            data = new char[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                data[i] = array[i];
            }
        }

        public StringDS(string str)
        {
            data = new char[str.Length];
            for(int i = 0; i < str.Length; i++)
            {
                data[i] = str[i];
            }
        }

        public char this[int index]
        {
            get { return data[index]; }
        }

        public int GetLength()
        {
            return data.Length;
        }

        public int Compare(StringDS s)
        {
            //if two strings the same, return 0
            //if current string less than s, return -1
            //if current string greater than s, return 1
            //use ternary method
            int len = this.GetLength() < s.GetLength() ? this.GetLength() : s.GetLength();
            //get the shorter one
            int index = -1;
            for(int i = 0; i < len; i++)
            {
                if(this[i] != s[i])
                {
                    index = i;
                    break;
                }
            }
            if(index != -1) //means have different elements
            {
                if(this[index] > s[index])
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else //means index from 0 to len they have the same elements
            {
                if(this.GetLength() == s.GetLength())
                {
                    return 0;
                }
                else
                {
                    if(this.GetLength() > s.GetLength())
                    {
                        return 1;
                    }
                    else 
                    { 
                        return -1;
                    }
                }
            }
        }

        public StringDS SubString(int index, int length)
        {
            char[] newData = new char[length];
            for(int i = index; i < index + length; i++)
            {
                newData[i - index] = data[i];
            }
            return new StringDS(newData);
        }

        public static StringDS Contact (StringDS s1,StringDS s2)
        {
            char[] newData = new char[s1.GetLength() + s2.GetLength()];
            for(int i = 0; i < s1.GetLength(); i++)
            {
                newData[i] = s1[i];
            }
            for(int j = s1.GetLength(); j < s1.GetLength()+s2.GetLength(); j++)
            {
                newData[j] = s2[j - s1.GetLength()];
            }
            return new StringDS(newData);
        }

        public int IndexOf(StringDS s)
        {
            for(int i = 0; i < this.GetLength() - s.GetLength(); i++)
            {
                bool isEqual = true;
                for (int j = i; j < 1 + s.GetLength(); j++)
                {
                    if(this[j] != s[j - i])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual)
                {
                    return i;
                }
                else
                {
                    continue;
                }
            }
            return -1;
        }
    }
}
