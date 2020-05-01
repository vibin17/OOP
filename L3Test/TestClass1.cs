using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L3;

namespace L3Test
{
    [TestFixture]
    public class TestClass1
    {
        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 3 }, 3)]
        [TestCase(new int[] { 2, 4 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2.5)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 3, 5}, 3)]
        [TestCase(new int[] { 2, 2, 2, 2, 2,  2 }, 2)] 
        [TestCase(new int[] { -1, 1 }, 0)]
        [TestCase(new int[] { -1, 0, 4 }, 1)]
        [TestCase(new int[] { -2, -5}, -3.5)]
        [Test]
        public void TestMethod(int[] array, double arrAvRes)
        {
            Assert.IsTrue(Program.arrAv(array) == arrAvRes);
        }
    }
}
