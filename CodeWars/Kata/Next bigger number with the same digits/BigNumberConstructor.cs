using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Next_bigger_number_with_the_same_digits
{
    class BigNumberConstructor
    {
        public static long NextBiggerNumber(long n)
        {
            int[] tempArr = TransformLongToArray(n);
            string tempStr = "";

            for(int i = tempArr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(tempArr[i]);
                tempStr += tempArr[i];
                Console.WriteLine("New number: "+tempStr);
            }

            return ConvertStringToLong(tempStr);
        }

        public static int[] TransformLongToArray(long n)
        {
            string tempStr = n.ToString();
            int[] tempArr = new int[tempStr.Length];

            for(int i = 0; i < tempStr.Length; i++)
            {
                tempArr[i] = Convert.ToInt32(Char.GetNumericValue(tempStr[i]));
            }

            return SortArray(tempArr);
        }

        private static int[] SortArray(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        private static long ConvertStringToLong(string strToConvert)
        {
            return Convert.ToInt64(strToConvert);
        }
    }
}
