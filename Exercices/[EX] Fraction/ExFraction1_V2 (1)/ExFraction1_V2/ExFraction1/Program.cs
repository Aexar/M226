using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFraction1 {
  class Program {
    static void Main(string[] args) {
      Fraction a = new Fraction(2, 7);
      Fraction b = new Fraction(6);
      Fraction c = new Fraction(17.0f);
      Fraction d = new Fraction(2.0);
      Fraction e = new Fraction("3/4");
      Fraction g = new Fraction(new string[] { "3", "44" });
      Fraction h = new Fraction("4444/");
      Console.WriteLine(h.ToString());

      Fraction f = new Fraction(d);
      Console.WriteLine(f.ToString());
    }
  }
}
