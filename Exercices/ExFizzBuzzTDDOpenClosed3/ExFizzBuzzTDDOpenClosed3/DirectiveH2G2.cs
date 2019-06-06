using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3 {
  public class DirectiveH2G2 : Directive {

    public DirectiveH2G2(string word) : base(word){
      // No action
    }

    public override string Apply(int pnb) {
      if (pnb.ToString().Contains("42")) {
        return this.Word;
      }
      return "";
    }

  }

}
