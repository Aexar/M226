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
    public class TravelModeByPlaneTests
    {
        [TestMethod()]
        public void TravelModeByPlaneTestConstructor()
        {
            TravelModeByPlane travelModeByPlane = new TravelModeByPlane(20);
            List<String> target = travelModeByPlane.AvailableTravelClasses;
            
            Assert.IsTrue(target.Contains("Classe économique"));
            Assert.IsTrue(target.Contains("Classe affaire"));
            Assert.IsTrue(target.Contains("Première classe"));

        }

        [TestMethod()]
        public void ComputeCarbonFootprintTestEconomicClass()
        {
            TravelModeByPlane travelModeByPlane = new TravelModeByPlane(20);
            double target = travelModeByPlane.ComputeCarbonFootprint(10, "Classe économique");
            Assert.AreEqual(200.0, target);
        }
        [TestMethod()]
        public void ComputeCarbonFootprintTestAffairClass()
        {
            TravelModeByPlane travelModeByPlane = new TravelModeByPlane(20);
            double target = travelModeByPlane.ComputeCarbonFootprint(10, "Classe affaire");
            Assert.AreEqual(800.0, target);
        }
        [TestMethod()]
        public void ComputeCarbonFootprintTestFirstClass()
        {
            TravelModeByPlane travelModeByPlane = new TravelModeByPlane(20);
            double target = travelModeByPlane.ComputeCarbonFootprint(10, "Première classe");
            Assert.AreEqual(1600.0, target);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ComputeCarbonFootprintTestInvalidClass()
        {
            TravelModeByPlane travelModeByPlane = new TravelModeByPlane(20);
            double target = travelModeByPlane.ComputeCarbonFootprint(10, "premium");
        }
    }
}