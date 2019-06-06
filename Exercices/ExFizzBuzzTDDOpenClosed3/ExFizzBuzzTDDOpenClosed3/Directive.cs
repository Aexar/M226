using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDDOpenClosed3 {
  public abstract class Directive {
    private string _word;

    public string Word {
      get { return _word; }
      set { _word = value; }
    }

    public Directive(string word) {
      //this.Word = word.ToUpper();
      this.Word = word;
    }

    public abstract string Apply(int nb);

    //public virtual string Apply(int number) {
    //  return number.ToString();
    //}
  }
}
