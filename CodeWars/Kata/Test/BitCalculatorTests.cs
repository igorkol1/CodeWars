using CodeWars.Kata.Bit_calculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    [TestFixture]
    class BitCalculatorTests
    {

        [Test]
        public void BitCalculatorTest()
        {
            Assert.AreEqual(2, BitCalculator.Calculate("1", "1"));
            Assert.AreEqual(4, BitCalculator.Calculate("10", "10"));
            Assert.AreEqual(2, BitCalculator.Calculate("10", "0"));
            Assert.AreEqual(3, BitCalculator.Calculate("10", "1"));
        }

    }
}
