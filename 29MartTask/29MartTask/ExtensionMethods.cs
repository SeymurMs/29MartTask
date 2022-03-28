using System;
using System.Collections.Generic;
using System.Text;

namespace _29MartTask
{
    internal static class ExtensionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0 )
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsContainsDigit(this string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (char.IsDigit(num[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ToCapitalize(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
            
            
        }
        public static int [] GetValueIndexes(this string str, char ch)
        {
            int[] indexes = new int[0];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch )
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = i;
                }
            }
            return indexes;

        }

    }
}
