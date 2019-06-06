using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExFizzBuzzTDDOpenClosed3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3.Tests {
  [TestClass()]
  public class DirectiveTests {
    [TestMethod()]
    //[DataRow(1, "1")]
    public void CtorTest1() {

      //Arrange
      DirectiveMultiple target = new DirectiveMultiple("Hi", 42);

      //Act
      

      //Assert
      Assert.AreEqual(42, target.Multiple);
      Assert.AreEqual("Hi", target.Word);
    }

    [TestMethod()]
    //[DataRow(1, "1")]
    public void ApplyMultipleShouldReturnMultiple() {

      //Arrange
      DirectiveMultiple target = new DirectiveMultiple("MultipleOfTwo", 2);

      //Act

      //Assert
      Assert.AreEqual("MultipleOfTwo", target.Apply(2));
      Assert.AreEqual("", target.Apply(3));
    }
  }
}