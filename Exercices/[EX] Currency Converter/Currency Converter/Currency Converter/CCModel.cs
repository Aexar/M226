using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class CCModel
    {
        private double _rate;
        private double _source;
        

        public double Source { get => _source; set => _source = value; }
        public double Rate { get => _rate; set => _rate = value; }

        public CCModel(double paramRate)
        {
            Rate = paramRate;
        }

        private double Convert(double paramSource)
        {
            double destination;
            Source = paramSource;
            destination = Source * Rate;

            return destination;
        }
    }
}
