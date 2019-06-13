using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingMeter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Tests
{
    [TestClass()]
    public class VanRateTests
    {
        [TestMethod()]
        public void VanRateTestName()
        {
            VanRate target = new VanRate("name", 10);
            Assert.AreEqual("name", target.Name);
        }
        [TestMethod()]
        public void VanRateTestHeight()
        {
            VanRate target = new VanRate("name", 10);
            Assert.AreEqual(10, target.Height);
        }
        [TestMethod()]
        public void VanRateTestCostForOneSlot()
        {
            VanRate target = new VanRate("name", 10);
            Assert.AreEqual(1.50M, target.CostForOneSlot);
        }

        [TestMethod()]
        public void ComputeParkingCostTest160cm12Hd120()
        {
            VanRate vanRate = new VanRate("1.6 12h d120", 1.6);
            DateTime begin = new DateTime(2019, 06, 13, 12, 34, 20);
            decimal target = vanRate.ComputeParkingCost(begin, 120);

            Assert.AreEqual(12.00M, target);
        }
        [TestMethod()]
        public void ComputeParkingCostTest180cm16Hd45()
        {
            VanRate vanRate = new VanRate("1.8 16h d45", 1.8);
            DateTime begin = new DateTime(2019, 06, 13, 16, 34, 20);
            decimal target = vanRate.ComputeParkingCost(begin, 45);

            Assert.AreEqual(4.50M, target);
        }
        [TestMethod()]
        public void ComputeParkingCostTest220cm16Hd45()
        {
            VanRate vanRate = new VanRate("2.2 16h d45", 2.2);
            DateTime begin = new DateTime(2019, 06, 13, 16, 34, 20);
            decimal target = vanRate.ComputeParkingCost(begin, 45);

            Assert.AreEqual(9.00M, target);
        }
        [TestMethod()]
        public void ComputeParkingCostTest180cm21Hd45()
        {
            VanRate vanRate = new VanRate("1.8 21H d45", 1.8);
            DateTime begin = new DateTime(2019, 06, 13, 21, 34, 20);
            decimal target = vanRate.ComputeParkingCost(begin, 45);

            Assert.AreEqual(0.00M, target);
        }
    }
}