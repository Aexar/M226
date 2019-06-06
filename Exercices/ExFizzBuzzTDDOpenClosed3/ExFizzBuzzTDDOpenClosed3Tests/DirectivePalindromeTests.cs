using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExFizzBuzzTDDOpenClosed3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3.Tests {
  [TestClass()]
  public class DirectivePalindromeTests {
    [TestMethod()]
    [DataRow(1, 1)]
    [DataRow(2, 2)]
    [DataRow(12, 21)]
    [DataRow(789, 987)]
    [DataRow(1001, 1001)]
    [DataRow(1000, 0001)]
    public void ReverseTest(int number1, int expected) {
      // Arrange
      DirectivePalindrome target = new DirectivePalindrome("x");
      // Act
      // Assert
      Assert.AreEqual(expected, target.Reverse(number1));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ReverseNegativeException() {
      DirectivePalindrome target = new DirectivePalindrome("x");

      target.Reverse(-12);
    }

    [TestMethod]
    public void Reverse123ShouldReturnEmptyString() {

      DirectivePalindrome target = new DirectivePalindrome("x");
      
      Assert.AreEqual("",target.Apply(123));
    }

    [TestMethod]
    public void PalindromeShouldReturnWordTest() {
      DirectivePalindrome target = new DirectivePalindrome("x");

      Assert.AreEqual("x", target.Apply(12321));
    }

    [TestMethod]
    public void PalindromeLowerThan10ShouldNotBePalindrome() {
      DirectivePalindrome target = new DirectivePalindrome("x");

      Assert.AreEqual("", target.Apply(7));
    }
  }
}