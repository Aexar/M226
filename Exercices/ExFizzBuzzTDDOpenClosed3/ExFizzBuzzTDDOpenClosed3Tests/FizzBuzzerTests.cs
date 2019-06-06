using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExFizzBuzzTDDOpenClosed3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3.Tests {
  [TestClass()]
  public class FizzBuzzerTests {

    [TestMethod()]
    public void CtorTest() {

      //Arrange
      //FizzBuzzer target = new FizzBuzzer();

      //Act


      //Assert
      //Assert.IsNotNull(target);
    }
    [TestMethod()]
    [DataRow(1, "1")]
    [DataRow(2, "2")]
    [DataRow(3, "Fizz")]
    [DataRow(4, "4")]
    [DataRow(5, "Buzz")]
    [DataRow(7, "Bang")]
    [DataRow(15,"FizzBuzz")]
    public void ApplyXShouldReturnYTest(int x, string y) {

      //Arrange
      //FizzBuzzer target = new FizzBuzzer();

      //Act
      //// Assert.AreEqual(y, result);
    }
  }
}