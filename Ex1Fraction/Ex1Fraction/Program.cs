using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction aFraction = new Fraction(12, 42);

            Console.WriteLine("aFraction = {0}", aFraction.ToString());

            Fraction bFraction = new Fraction(7, 1);

            return;
        }
    }
}
