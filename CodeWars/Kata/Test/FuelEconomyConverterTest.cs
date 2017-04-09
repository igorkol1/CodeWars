using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    public class FuelEconomyConverterTest
    {

        [Test]
        public void lp100km2mpgTest()
        {
            Assert.AreEqual(26.13, FuelEconomyConverter.lp100km2mpg(9));
        }

        [Test]
        public void mpg2lp100kmTest()
        {
            Assert.AreEqual(5.6, FuelEconomyConverter.mpg2lp100km(42));
        }
    }
}
