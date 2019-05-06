using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Fraction
{
    class Fraction
    {
        private int v1;

        public Fraction(int denominator, int nominator)
        {
            this.v1 = nominator/denominator;

        }

        public string ToString()
        {
            return v1.ToString(); ;
        }
    }
}
