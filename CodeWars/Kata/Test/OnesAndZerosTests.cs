using CodeWars.Kata.Ones_and_Zeros;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    class OnesAndZerosTests
    {
        int[] Test1 = new int[] { 0, 0, 0, 0 };
        int[] Test2 = new int[] { 1, 1, 1, 1 };
        int[] Test3 = new int[] { 0, 1, 1, 0 };
        int[] Test4 = new int[] { 0, 1, 0, 1 };

        [Test]
        public void OnesAndZerosTest()
        {
            Assert.AreEqual(0, OnesAndZeros.binaryArrayToNumber(Test1));
            Assert.AreEqual(15, OnesAndZeros.binaryArrayToNumber(Test2));
            Assert.AreEqual(6, OnesAndZeros.binaryArrayToNumber(Test3));
            Assert.AreEqual(5, OnesAndZeros.binaryArrayToNumber(Test4));
        }
    }
}
