using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.The_Coupon_Code
{
    class TheCouponCode
    {

        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            bool couponStatus;

            couponStatus = CheckCouponCode(enteredCode, correctCode) && CheckCouponeDate(currentDate,expirationDate);

            return couponStatus;
        }

        private static bool CheckCouponCode(string enteredCode, string correctCode)
        {
            return enteredCode == correctCode;
        }

        private static bool CheckCouponeDate(string currentDate, string expirationDate)
        {
            DateTime currentInDateFormat = Convert.ToDateTime(currentDate);
            DateTime expirationInDateFormat = Convert.ToDateTime(expirationDate);

            Console.WriteLine(currentInDateFormat + " " + expirationDate);

            return currentInDateFormat<=expirationInDateFormat;
        }

    }
}
