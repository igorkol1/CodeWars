using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Find_the_unknown_digit
{
    class Runes
    {
        public static int solveExpression(string expression)
        {
            int missingDigit = -1;

            RunesDecoder decoder = new RunesDecoder(expression);

            try
            {
                missingDigit = decoder.Decode();
            }
            catch
            {
                missingDigit = -1;
            }

            

            return missingDigit;
        }

    }
}
