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
    public class TravelMode
    {
        private double _GramCO2PerKm;

        public double GramCO2PerKm
        {
            get { return _GramCO2PerKm; }
            set { _GramCO2PerKm = value; }
        }

        public TravelMode(double gramCO2PerKm)
        {
            this.GramCO2PerKm = gramCO2PerKm;
        }
        
        /*
         * Name : ComputeCarbonFootprint
         * Desc : Compute how much grams of CO2 got emitted by the distance
         */
        public double ComputeCarbonFootprint(int distance)
        {
            // Calculate carbonFootprint => distance * GramCO2PerKm
            double carbonFootprint = (double)distance * this.GramCO2PerKm;

            // return
            return carbonFootprint;
        }
    }
}
