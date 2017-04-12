using CodeWars.Kata.Find_the_odd_int;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    class FindTheOddIntTests
    {
        [Test]
        public void FindTheOddIntTest()
        {
            Assert.AreEqual(5, FindTheOddInt.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            Assert.AreEqual(-1, FindTheOddInt.find_it(new[] { 1, 1, 2, -2, 5, 2, 4, 4, -1, -2, 5 }));
            Assert.AreEqual(5, FindTheOddInt.find_it(new[] { 20, 1, 1, 2, 2, 3, 3, 5, 5, 4, 20, 4, 5 }));
            Assert.AreEqual(10, FindTheOddInt.find_it(new[] { 10 }));
            Assert.AreEqual(10, FindTheOddInt.find_it(new[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 }));
            Assert.AreEqual(1, FindTheOddInt.find_it(new[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 10, 10 }));
        }
    }
}
