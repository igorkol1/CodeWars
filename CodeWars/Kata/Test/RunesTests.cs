using CodeWars.Kata.Find_the_unknown_digit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    [TestFixture]
    class RunesTests
    {
        [Test]
        public void ReunesDecoderTest()
        {
            RunesDecoder decoder = new RunesDecoder("123*45?=5?088");

            decoder.GetExpresionResult();
            decoder.GetExpresionNumbers();

            Assert.AreEqual("5?088", decoder.result, "Get expresion result");
            Assert.AreEqual("123", decoder.numberA, "Get expresion numberA");
            Assert.AreEqual("45?", decoder.numberB, "Get expresion numberB");
        }

        [Test]
        public void RunesTest()
        {
            Assert.AreEqual(2, Runes.solveExpression("1+1=?"), "Answer for expression '1+1=?' ");
            Assert.AreEqual(6, Runes.solveExpression("123*45?=5?088"), "Answer for expression '123*45?=5?088' ");
            Assert.AreEqual(0, Runes.solveExpression("-5?*-1=5?"), "Answer for expression '-5?*-1=5?' ");
            Assert.AreEqual(-1, Runes.solveExpression("19--45=5?"), "Answer for expression '19--45=5?' ");
            Assert.AreEqual(5, Runes.solveExpression("??*??=302?"), "Answer for expression '??*??=302?' ");
            Assert.AreEqual(2, Runes.solveExpression("?*11=??"), "Answer for expression '?*11=??' ");
        }

    }
}
