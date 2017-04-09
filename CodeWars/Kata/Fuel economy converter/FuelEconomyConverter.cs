using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    class FuelEconomyConverter
    {
        public static double gallon = 3.785411784;
        public static double mile = 1.609344;

        public static double mpg2lp100km(double x)
        {
            return RoundToTwoDecimals(235.21 / x);
        }

        public static double lp100km2mpg(double x)
        {
            return RoundToTwoDecimals(235.21 / x);
        }

        private static double RoundToTwoDecimals(double numberToRound)
        {
            return Math.Round(numberToRound, 2, MidpointRounding.AwayFromZero);
        }
    }
}
