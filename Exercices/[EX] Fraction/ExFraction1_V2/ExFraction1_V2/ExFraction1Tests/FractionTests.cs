using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExFraction1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFraction1.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void FractionTest()
        {
            Fraction target = new Fraction(7);
            Assert.AreEqual("7 / 1", target.ToString());
        }

        [TestMethod()]
        public void FractionTest1()
        {
            Fraction target = new Fraction(7.2);
            Assert.AreEqual("7 / 1", target.ToString());
        }

        [TestMethod()]
        public void FractionTest2()
        {
            Fraction target = new Fraction(7.6);
            Assert.AreEqual("8 / 1", target.ToString());
        }

        [TestMethod()]
        public void FractionTest3()
        {
            Fraction target = new Fraction(7.75);
            Assert.AreEqual("8 / 1", target.ToString());
        }

        [TestMethod()]
        public void FractionTest4()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FractionTest5()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FractionTest6()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FractionTest7()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}