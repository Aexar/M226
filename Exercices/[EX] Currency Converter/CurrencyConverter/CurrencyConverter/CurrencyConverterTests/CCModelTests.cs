using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Tests {
  [TestClass()]
  public class CCModelTests {
    [TestMethod()]
    public void ctorTests() {
      CCModel target = new CCModel(1, 12);

      Assert.AreEqual(1, target.Rate);
      Assert.AreEqual(12, target.Source);
    }

    [TestMethod()]
    public void ctorTestOneParam() {
      CCModel target = new CCModel(2);

      Assert.AreEqual(2, target.Rate);
      Assert.AreEqual(0, target.Source);
    }

    [TestMethod()]
    public void ctorTestNoParam() {
      CCModel target = new CCModel();

      Assert.AreEqual(1.24, target.Rate);
      Assert.AreEqual(0, target.Source);
    }

    [TestMethod()]
    public void ConvertTest() {
      CCModel target = new CCModel(1.0);

      Assert.AreEqual(42, target.Convert(42));
    }

    [TestMethod()]
    public void ConvertTestRound() {
      CCModel target = new CCModel(1.0);

      Assert.AreEqual(42, target.Convert(42.1));
    }

    [TestMethod()]
    public void ConvertTestRoundDotFive() {
      CCModel target = new CCModel(1.0);

      Assert.AreEqual(42, target.Convert(42.5));
    }
    [TestMethod()]
    public void ConvertTestRoundDotFive2() {
      CCModel target = new CCModel(1.0);

      Assert.AreEqual(44, target.Convert(43.5));
    }
  }
}