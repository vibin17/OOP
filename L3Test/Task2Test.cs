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
    public class Task2Test
    {
        [TestCase(1, 2, 3)]
        [TestCase(0, -7, -7)]
        [TestCase(100, -1, 99)]
        [TestCase(-5, -5, -10)]
        [TestCase(0, 0, 0)]
        [Test]
        public void SumTest(int a, int b, int res)
        {
            Assert.IsTrue(L3.Program.Sum(a, b) == res);
        }
        [TestCase(1, 2, -1)]
        [TestCase(0, -7, 7)]
        [TestCase(100, -1, 101)]
        [TestCase(-5, -5, 0)]
        [TestCase(0, 0, 0)]
        [Test]
        public void SubTest(int a, int b, int res)
        {
            Assert.IsTrue(L3.Program.Sub(a, b) == res);
        }
    }
}
