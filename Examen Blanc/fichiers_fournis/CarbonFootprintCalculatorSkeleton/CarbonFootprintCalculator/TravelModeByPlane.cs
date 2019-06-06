/*
 * Project : CarbonFootprintCalculator
 * Author : Richard Aurélien
 * Description : A calculator to get the carbon footprint of 
 *               flights or train travel from geneva to other 
 *               places in the world
 * Version: 1.0.0
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprintCalculator
{
    public class TravelModeByPlane : TravelMode
    {
        private Dictionary<string, double> _ratiosForTravelClasses;
        private List<String> _availableTravelClasses;

        public Dictionary<string, double> RatiosForTravelClasses
        {
            get { return _ratiosForTravelClasses; }
            set { _ratiosForTravelClasses = value; }
        }


        public List<String> AvailableTravelClasses
        {
            get { return _availableTravelClasses; }
            set { _availableTravelClasses = value; }
        }

        public TravelModeByPlane(double gramCO2PerKm) : base(gramCO2PerKm)
        {
            // Initialize RatiosForTravelClasses
            this.RatiosForTravelClasses = new Dictionary<string, double>();
            this.RatiosForTravelClasses.Add("Classe économique", 1.0);
            this.RatiosForTravelClasses.Add("Classe affaire", 4.0);
            this.RatiosForTravelClasses.Add("Première classe", 8.0);

            // Initialize AvailableTravelClasses
            this.AvailableTravelClasses = new List<string>();
            this.AvailableTravelClasses.Add("Classe économique");
            this.AvailableTravelClasses.Add("Classe affaire");
            this.AvailableTravelClasses.Add("Première classe");
        }

        public double ComputeCarbonFootprint(int distance, string travelClass)
        {
            double carbonRatio = 0;

            // retrieve the carbon ratio
            this.RatiosForTravelClasses.TryGetValue(travelClass,out carbonRatio);

            // if it is = 0, then no travelClass
            if (carbonRatio == 0)
            {
                throw new ArgumentException();
            }

            // calculate carbonFootprint
            double carbonFootprint = (double)distance * this.GramCO2PerKm * carbonRatio;

            // return
            return carbonFootprint;
        }
    }
}
