using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExFizzBuzzTDDOpenClosed3 {
  class Program {
    private const string FIRST_WORD = "Fizz",
                         SECOND_WORD = "Buzz";
    private const int FIRST_MULTIPLE = 3,
                      SECOND_MULTIPLE = 5;

    static void Main(string[] args) {
      Directive[] directives = new Directive[] {
        new DirectiveMultiple(FIRST_WORD,FIRST_MULTIPLE),
        new DirectiveMultiple(SECOND_WORD,SECOND_MULTIPLE),
        new DirectiveMultiple("Bang",7),
        new DirectivePalindrome("Splash"),
        new DirectiveH2G2("H2G2"),
        new DirectiveDefaultArabic()
      };

      FizzBuzzer target = new FizzBuzzer(directives);

      int max = 1000;
      
      for (int i = 1; i < max; i++) {
        //if(target.Apply(i) == "FizzBuzzSplashBangH2G2") {
          Console.WriteLine(target.Apply(i));
        //}

      }
    }
  }
}
