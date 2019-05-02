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

namespace ExFractionGUI
{
    public class Fraction
    {
        // constantes
        private const int DEFAULT_DENOMINATOR = 1;
        private const int MOVE_DECIMAL = 100000000;

        // champs
        private int _numerator;
        private int _denominator;

        // propriétés
        private int Numerator
        {
            get { return this._numerator; }
            set { this._numerator = value; }
        }
        public int Denominator
        {
            get => _denominator;
            set => _denominator = value;
        }

        // constructeurs
        // constructeur désignés (designated constructor)
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            Reduce();
        }

        public Fraction(int numerator) : this(numerator, DEFAULT_DENOMINATOR)
        {
            // no code
        }

        public Fraction(float numerator) : this((int)(numerator * MOVE_DECIMAL), MOVE_DECIMAL)
        {
            //no code
        }

        public Fraction(double numerator) : this((int)Math.Round(numerator), DEFAULT_DENOMINATOR)
        {
            //no code
        }

        public Fraction(decimal numerator) : this((int)Math.Round(numerator), DEFAULT_DENOMINATOR)
        {
            // No code ;-)
        }

        public Fraction(Fraction fraction) : this(fraction.Numerator, fraction.Denominator)
        {
            // No code :-D
        }


        public Fraction(string values) : this(values.Split('/'))
        {
            // No code.
        }
        public Fraction(string[] values) : this(Int32.Parse(values[0]), Int32.Parse(values[0]))
        {
            // No code.
        }

        public Fraction Add(Fraction fractionAdd)
        {
            int resultNom = (fractionAdd._denominator * this._numerator) + (this._denominator * fractionAdd._numerator);
            int resultDen = (fractionAdd._denominator * this._denominator);

            Fraction result = new Fraction(resultNom, resultDen);
            return result;
        }

        public Fraction Sub(Fraction fractionSub)
        {
            int resultNom = (fractionSub._denominator * this._numerator) - (this._denominator * fractionSub._numerator);
            int resultDen = (fractionSub._denominator * this._denominator);

            Fraction result = new Fraction(resultNom, resultDen);
            return result;
        }

        // méthodes
        public override string ToString()
        {
            return this.Numerator.ToString() + " / " + this.Denominator.ToString();
        }

        public int ComputeGcd(int a, int b)
        {
            int gcd = 1;
            int num = 2;

            List<int> compoA = new List<int>();
            List<int> compoB = new List<int>();

            // get table for a
            while (a > 1)
            {
                if (a % num == 0)
                {
                    System.Console.Write(num + ",");

                    a = a / num;
                    compoA.Add(num);
                }
                else
                {
                    num = num + 1;
                }
            }

            System.Console.WriteLine("\n ------");
            num = 2;
            // get table for b
            while (b > 1)
            {
                // if num divides b
                if (b % num == 0)
                {
                    System.Console.Write(num + ",");
                    b = b / num;
                    compoB.Add(num);
                }
                else
                {
                    num = num + 1;
                }
            }

            foreach (var itemA in compoA)
            {
                foreach (var itemB in compoB)
                {
                    if (itemA == itemB)
                    {
                        gcd = gcd * itemA;
                        compoB.Remove(itemB);
                        break;
                    }
                }
            }
            return gcd;
        }

        private void Reduce()
        {
            int gcd = ComputeGcd(this.Numerator, this.Denominator);
            this.Numerator /= gcd;
            this.Denominator /= gcd;
        }
    }

    
}
