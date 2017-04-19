using CodeWars.Kata.Build_Tower;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    [TestFixture]
    class BuildTowerTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", BuildTowerKata.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", BuildTowerKata.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", BuildTowerKata.TowerBuilder(3)));
        }

    }
}
