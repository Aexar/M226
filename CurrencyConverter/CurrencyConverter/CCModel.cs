using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class CCModel
    {
        // Constant
        const double DEFAULT_RATE = 1.0;
        const double DEFAULT_SOURCE = 0.0;

        // Fields
        private double _rate;
        private double _source;

        // Properties
        public double Rate { get => _rate; set => _rate = value; }
        public double Source {
            get{return this._source; }
            set { this._source = Math.Round(value, MidpointRounding.ToEven); }

        }
        

        // Constructor
        public CCModel() : this (DEFAULT_RATE)
        {
            // No Code
        }
        public CCModel(double paramRate) :this (paramRate, DEFAULT_SOURCE)
        {
            // No Code
        }
        public CCModel(double paramRate, double paramSource)
        {
            this.Rate = paramRate;
            this.Source = paramSource;
        }

        // Convertor 
        public double Convert(double paramSource)
        {
            double destination;
            this.Source = paramSource;
            destination = this.Source * Rate;
            return destination;
        }
    }
}
