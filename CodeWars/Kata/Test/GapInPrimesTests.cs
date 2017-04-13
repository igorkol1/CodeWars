using CodeWars.Kata.Gap_in_Primes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    [TestFixture]
    public static class GapInPrimesTests
    {

        [Test]
        public static void GapInPrimesTest()
        {
            //Primes primes = new Primes(500);

            //primes.PrintPrimes();

            Assert.AreEqual(new long[] { 101, 103 }, GapInPrimes.Gap(2, 100, 110));
            Assert.AreEqual(new long[] { 103, 107 }, GapInPrimes.Gap(4, 100, 110));
            Assert.AreEqual(null, GapInPrimes.Gap(6, 100, 110));
            Assert.AreEqual(new long[] { 359, 367 }, GapInPrimes.Gap(8, 300, 400));
            Assert.AreEqual(new long[] { 337, 347 }, GapInPrimes.Gap(10, 300, 400));
        }
    }
}
