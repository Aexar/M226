using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3 {

  public class FizzBuzzer {

    

    private Directive[] _directives;

    public Directive[] Directives { get => _directives; set => _directives = value; }


    public FizzBuzzer(Directive[] pDirectives) {
      this.Directives = pDirectives;
    }

    public string Apply(int number) {

      string result = "";

      for (int i = 0; i < Directives.Length-1; i++) {
        result += this.Directives[i].Apply(number); 
      }
      
      return 
        result == "" ?
        this.Directives[this.Directives.Length-1].Apply(number):
        result;
    }
  }
  
}
