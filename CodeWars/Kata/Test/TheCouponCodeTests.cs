using CodeWars.Kata.The_Coupon_Code;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    class TheCouponCodeTests
    {
        [Test]
        public static void TheCouponCodeTest()
        {
            Assert.AreEqual(true, TheCouponCode.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));

            Assert.AreEqual(false, TheCouponCode.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));
        }
    }
}
