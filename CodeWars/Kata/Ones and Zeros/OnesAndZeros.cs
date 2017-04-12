using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Ones_and_Zeros
{
    class OnesAndZeros
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            return Convert.ToInt32(ChangeArrayIntoString(BinaryArray), 2);
        }

        private static string ChangeArrayIntoString(int[] arrayToChange)
        {
            string temp = "";

            foreach(int number in arrayToChange)
            {
                Console.WriteLine(number);
                temp = temp + number.ToString();
            }
            return temp;
        }
    }
}
