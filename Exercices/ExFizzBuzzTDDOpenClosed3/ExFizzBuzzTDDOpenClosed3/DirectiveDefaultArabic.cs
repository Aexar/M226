using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3 {
  public class DirectiveDefaultArabic : Directive {
    public DirectiveDefaultArabic() : base("") {
      
    }

    public override string Apply(int number) {
      return number.ToString();
    }
  }
}
