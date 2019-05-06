/*
 M226
 07/02/19
 Ex1Fraction
 Tombez, Valverde, Sickenberg, Sewer
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFraction1 {
  public class Fraction {
    // constantes
    private const int DEFAULT_DENOMINATOR = 1;

    // champs
    private int _numerator;
    private int _denominator;

    // propriétés
    private int Numerator {
      get { return this._numerator;  }
      set { this._numerator = value;  }
    }
    public int Denominator {
      get => _denominator;
      set => _denominator = value;
    }

    // constructeurs
    // constructeur désignés (designated constructor)
    public Fraction(int numerator, int denominator) {
      this.Numerator = numerator;
      this.Denominator = denominator;
    }

    public Fraction(int numerator):this(numerator, DEFAULT_DENOMINATOR) {
      // no code
    }

    public Fraction(float numerator):this((int)Math.Round(numerator), DEFAULT_DENOMINATOR) {
      //no code
    }

    public Fraction(double numerator):this((int)Math.Round(numerator), DEFAULT_DENOMINATOR) {
      //no code
    }

    public Fraction(decimal numerator):this((int)Math.Round(numerator), DEFAULT_DENOMINATOR) {
      // No code ;-)
    }

    public Fraction(Fraction fraction):this(fraction.Numerator, fraction.Denominator) {
      // No code :-D
    }


    public Fraction(string values) : this(values.Split('/')) {
      // No code.
    }
    public Fraction (string[] values) : this(Int32.Parse(values[0]), Int32.Parse(values[1])) {
      // No code.
    } 


    // méthodes
    public override string ToString() { 
      return this.Numerator.ToString() + " / " + this.Denominator.ToString();
    }
  }
}
