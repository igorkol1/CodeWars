using CodeWars.Kata.String_Integer_Greater_than;
using NUnit.Framework;
using System;


namespace CodeWars.Kata.Test
{
    [TestFixture]
    class StringIntegerGreaterComparisonTests
    {
        [Test]
        public void StringIntegerGreaterComparisonTest()
        {
            Assert.IsFalse(StringIntegerGreaterComparison.StringIntGreaterThan("31", "162"), "Assert 1");
            Assert.IsFalse(StringIntegerGreaterComparison.StringIntGreaterThan("16", "162"), "Assert 2");
            Assert.IsTrue(StringIntegerGreaterComparison.StringIntGreaterThan("162", "54"), "Assert 3");

            Assert.IsFalse(StringIntegerGreaterComparison.StringIntGreaterThan("162", "162"), "Assert 4");

            Assert.IsFalse(StringIntegerGreaterComparison.StringIntGreaterThan("230", "231"), "Assert 5");
            Assert.IsFalse(StringIntegerGreaterComparison.StringIntGreaterThan("230", "241"), "Assert 6");

            Assert.IsTrue(StringIntegerGreaterComparison.StringIntGreaterThan("162", "154"),"Assert 7");

            Assert.IsFalse(StringIntegerGreaterComparison.StringIntGreaterThan("3298796435132165154896798416516156", "3329879643513216515489679841651615"), "Assert 8");
            Assert.IsFalse(StringIntegerGreaterComparison.StringIntGreaterThan("-1329879643513216515489679841651615", "-956189648947395809432803247598442"), "Assert 8,5");

            Assert.IsFalse(StringIntegerGreaterComparison.StringIntGreaterThan("-1", "3"), "Assert 9");
            Assert.IsTrue(StringIntegerGreaterComparison.StringIntGreaterThan("2", "-1"), "Assert 10");
            Assert.IsTrue(StringIntegerGreaterComparison.StringIntGreaterThan("-1", "-4"), "Assert 10");

        }
    }
}
