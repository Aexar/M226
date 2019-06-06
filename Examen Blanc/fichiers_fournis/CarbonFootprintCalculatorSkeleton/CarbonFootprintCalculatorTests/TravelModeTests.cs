using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarbonFootprintCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprintCalculator.Tests
{
    [TestClass()]
    public class TravelModeTests
    {
        [TestMethod()]
        public void TravelModeTestConstructor()
        {
            TravelMode target = new TravelMode(256.0);
            double gramCO2PerKm = target.GramCO2PerKm;
            Assert.AreEqual(256.0, gramCO2PerKm);
        }

        [TestMethod()]
        public void ComputeCarbonFootprintTest()
        {
            TravelMode target = new TravelMode(256.0);
            double result = target.ComputeCarbonFootprint(10);
            Assert.AreEqual(2560.0, result);
        }
    }
}