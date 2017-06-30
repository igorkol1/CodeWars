using CodeWars.Kata.Next_bigger_number_with_the_same_digits;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    [TestFixture]
    class BigNumberConstructorTests
    {
        [Test]
        public void TransformLongToArrayTest()
        {
            Console.WriteLine("12");
            int[] tempArr = new int[]{ 1, 2 };
            Assert.AreEqual(tempArr, BigNumberConstructor.TransformLongToArray(12));

            Console.WriteLine("513");
            tempArr = new int[]{ 1, 3, 5};
            Assert.AreEqual(tempArr, BigNumberConstructor.TransformLongToArray(513));

            Console.WriteLine("2017");
            tempArr = new int[] { 0, 1, 2, 7};
            Assert.AreEqual(tempArr, BigNumberConstructor.TransformLongToArray(2017));

            Console.WriteLine("414");
            tempArr = new int[] { 1, 4, 4 };
            Assert.AreEqual(tempArr, BigNumberConstructor.TransformLongToArray(414));

            Console.WriteLine("144");
            tempArr = new int[] { 1, 4, 4 };
            Assert.AreEqual(tempArr, BigNumberConstructor.TransformLongToArray(144));
        }


        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Small Number");
            Assert.AreEqual(21, BigNumberConstructor.NextBiggerNumber(12));
            Assert.AreEqual(531, BigNumberConstructor.NextBiggerNumber(513));
            Assert.AreEqual(2071, BigNumberConstructor.NextBiggerNumber(2017));
            Assert.AreEqual(441, BigNumberConstructor.NextBiggerNumber(414));
            Assert.AreEqual(414, BigNumberConstructor.NextBiggerNumber(144));
        }


    }
}
