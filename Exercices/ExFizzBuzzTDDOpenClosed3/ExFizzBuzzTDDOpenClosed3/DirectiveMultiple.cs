using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3 {
  public class DirectiveMultiple : Directive {

    private int _multiple;

    //Constructeur
    public DirectiveMultiple(string word, int multiple) : base(word) {
      this.Multiple = multiple;
    }

    

    public int Multiple { get => _multiple; set => _multiple = value; }

    public override string Apply(int nb) {
      if (nb%this.Multiple == 0) {
        return this.Word;
      }

      return "";
    }
    
  }
}
