using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFizzBuzzTDD {
  public class NumericStringStorage {
    private int _number;
    public int Number {
      get { return _number; }
      private set { _number = value; }
    }

    private string _word;
    public string Word {
      get { return _word; }
      private set { _word = value; }
    }

    public NumericStringStorage(int pNumber, string pWord) {
      this.Number = pNumber;
      this.Word = pWord;
    }
  }
}
