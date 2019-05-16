using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCM.Tests
{
    [TestClass()]
    public class BeverageTests
    {
        [TestMethod()]
        public void BeverageTestCoca2CHF1Liter()
        {
            Beverage target = new Beverage("Coca", 2.50f, 1);
            Assert.AreEqual("Coca", target.Name);
            Assert.AreEqual(2.50, target.Price, 0.01);
            Assert.AreEqual(1, target.Volume);
            Assert.AreEqual(0, target.Percentage);
        }

        [TestMethod()]
        public void BeverageTestVodka8CHF3Cl40D()
        {
            Beverage target = new Beverage("Vodka", 8, 0.03f, 40);
            Assert.AreEqual("Vodka", target.Name);
            Assert.AreEqual(8, target.Price);
            Assert.AreEqual(0.03, target.Volume,0.01);
            Assert.AreEqual(40, target.Percentage);
        }
    }
}