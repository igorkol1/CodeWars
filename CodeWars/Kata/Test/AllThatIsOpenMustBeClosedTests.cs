using System;
using NUnit.Framework;
using System;
using CodeWars.Kata.All_that_is_open_must_be_closed;

namespace CodeWars.Kata.Test
{
    [TestFixture]
    class AllThatIsOpenMustBeClosedTests
    {
        [Test]
        public void AllThatIsOpenMustBeClosedTest()
        {
            Assert.AreEqual(true, AllThatIsOpenMustBeClosed.IsBalanced("(Sensei says yes!)", "()"),"Assert 1");
            Assert.AreEqual(false, AllThatIsOpenMustBeClosed.IsBalanced("(Sensei says no!", "()"), "Assert 2");

            Assert.AreEqual(true, AllThatIsOpenMustBeClosed.IsBalanced("(Sensei [says] yes!)", "()[]"), "Assert 3");
            Assert.AreEqual(false, AllThatIsOpenMustBeClosed.IsBalanced("(Sensei [says) no!]", "()[]"), "Assert 4");

            Assert.AreEqual(true, AllThatIsOpenMustBeClosed.IsBalanced("Sensei says -yes-!", "--"), "Assert 5");
            Assert.AreEqual(false, AllThatIsOpenMustBeClosed.IsBalanced("Sensei -says no!", "--"), "Assert 6");
        }
    }
}
