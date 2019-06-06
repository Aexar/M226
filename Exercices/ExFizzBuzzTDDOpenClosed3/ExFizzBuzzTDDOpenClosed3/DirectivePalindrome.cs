using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3 {
  public class DirectivePalindrome : Directive {

    public DirectivePalindrome(string word) : base(word) {
      // No action
    }
    public override String Apply(int pnb) {
      if (pnb==Reverse(pnb) && pnb > 10) {
        return this.Word;
      }
      return "";
    }

    public int Reverse(int number) {
      int reversedNumber = 0;
      if (number < 0) {
        throw new ArgumentException("Negative number given in Reverse()");
      }
      // CDU
      while (number > 0) {
        int unit = number % 10;
        reversedNumber *= 10;
        reversedNumber += unit;
        number /= 10;
      }

      return reversedNumber;
    }
  }
}
