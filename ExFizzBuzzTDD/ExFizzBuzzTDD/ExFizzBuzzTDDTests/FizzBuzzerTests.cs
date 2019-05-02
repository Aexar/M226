using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExFizzBuzzTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDD.Tests {
  [TestClass()]
  public class FizzBuzzerTests {
    [TestMethod()]
    public void Apply1ShouldReturn1Test() {
      // Arrange
      FizzBuzzer target = new FizzBuzzer();
      // Act
      string result = target.Apply(1);
      // Assert
      Assert.AreEqual("1", result);
    }

    [TestMethod()]
    public void Apply2ShouldReturn2Test() {
      // Arrange
      FizzBuzzer target = new FizzBuzzer();
      // Act
      string result = target.Apply(2);
      // Assert
      Assert.AreEqual("2", result);
    }

    [TestMethod()]
    public void Apply3ShouldReturnFizzTest() {
      // Arrange
      FizzBuzzer target = new FizzBuzzer();
      // Act
      string result = target.Apply(3);
      // Assert
      Assert.AreEqual("Fizz", result);
    }

    [TestMethod()]
    public void Apply5ShouldReturnBuzzTest() {
      // Arrange
      FizzBuzzer target = new FizzBuzzer();
      // Act
      string result = target.Apply(5);
      // Assert
      Assert.AreEqual("Buzz", result);
    }

    [TestMethod()]
    public void Apply6ShouldReturnFizzTest() {
      // Arrange
      FizzBuzzer target = new FizzBuzzer();
      // Act
      string result = target.Apply(6);
      // Assert
      Assert.AreEqual("Fizz", result);
    }

    [TestMethod()]
    public void Apply9ShouldReturnFizzTest() {
      // Arrange
      FizzBuzzer target = new FizzBuzzer();
      // Act
      string result = target.Apply(9);
      // Assert
      Assert.AreEqual("Fizz", result);
    }
    [TestMethod()]
    public void Apply10ShouldReturnBuzzTest() {
      // Arrange
      FizzBuzzer target = new FizzBuzzer();
      // Act
      string result = target.Apply(10);
      // Assert
      Assert.AreEqual("Buzz", result);
    }
    [TestMethod()]
    public void Apply15ShouldReturnFizzBuzzTest() {
      // Arrange
      FizzBuzzer target = new FizzBuzzer();
      // Act
      string result = target.Apply(15);
      // Assert
      Assert.AreEqual("FizzBuzz", result);
    }
    [TestMethod()]
    public void Apply30ShouldReturnFizzBuzzTest() {
      // Arrange
      FizzBuzzer target = new FizzBuzzer();
      // Act
      string result = target.Apply(30);
      // Assert
      Assert.AreEqual("FizzBuzz", result);
    }
  }
}