using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Bit_calculator
{
    class BitCalculator
    {
        public static int Calculate(string num1, string num2)
        {
            int intNumberA = Convert.ToInt32(num1,2);
            int intNumberB = Convert.ToInt32(num2,2);

            Console.WriteLine(intNumberA + " " + intNumberB);

            return intNumberA+intNumberB;
        }
    }
}
