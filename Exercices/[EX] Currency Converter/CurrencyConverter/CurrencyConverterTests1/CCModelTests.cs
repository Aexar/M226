using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Tests
{
    [TestClass()]
    public class CCModelTests
    {
        [TestMethod()]
        public void CCModelNoParam()
        {
            CCModel target = new CCModel();
            Assert.AreEqual(1.0, target.Rate);
            Assert.AreEqual(0.0, target.Rate);
        }
        [TestMethod()]
        public void CCModelOneParam()
        {
            CCModel target = new CCModel(23);
            Assert.AreEqual(23, target.Rate);
            Assert.AreEqual(0.0, target.Rate);
        }
        [TestMethod()]
        public void CCModelTwoParam()
        {
            CCModel target = new CCModel(22, 10.5);
            Assert.AreEqual(1.0, target.Rate);
            Assert.AreEqual(0.0, target.Rate);
        }

        [TestMethod()]
        public void ConvertTest1()
        {
            CCModel target = new CCModel(8);
            target.Convert(12.893);
            Assert.Fail();
        }
        public void ConvertTest2()
        {
            Assert.Fail();
        }
        public void ConvertTest3()
        {
            Assert.Fail();
        }
        public void ConvertTest4()
        {
            Assert.Fail();
        }
        public void ConvertTest5()
        {
            Assert.Fail();
        }
    }
}