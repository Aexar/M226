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
    public class MotorcycleRateTests
    {
        [TestMethod()]
        public void MotorcycleRateTestConstructor()
        {
            MotorcycleRate target = new MotorcycleRate("name");
            Assert.AreEqual("name", target.Name);
            Assert.AreEqual(0.75M, target.CostForOneSlot);
        }
        [TestMethod()]
        public void MotorcycleRateTestComputeParkingCost21h45d()
        {
            MotorcycleRate motorcycleRate = new MotorcycleRate("name");
            DateTime begin = new DateTime(2019, 06, 13, 21, 34, 20);
            decimal target = motorcycleRate.ComputeParkingCost(begin, 45);

            Assert.AreEqual(0.00M, target);
        }
        [TestMethod()]
        public void MotorcycleRateTestComputeParkingCost16h45d()
        {
            MotorcycleRate motorcycleRate = new MotorcycleRate("name");
            DateTime begin = new DateTime(2019, 06, 13, 16, 34, 20);
            decimal target = motorcycleRate.ComputeParkingCost(begin, 45);

            Assert.AreEqual(2.25M, target);
        }
    }
}