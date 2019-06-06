using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExFizzBuzzTDDOpenClosed3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3.Tests {
  [TestClass()]
  public class DirectiveH2G2Tests {
    
    [TestMethod()]
    [DataRow(6546456, "")]
    [DataRow(8642, "H2G2")]
    public void ApplyTest(int number, string excepted) {
      DirectiveH2G2 target = new DirectiveH2G2("H2G2");

      Assert.AreEqual(excepted, target.Apply(number));
    }
  }
}