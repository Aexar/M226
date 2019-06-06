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
    class TravelModeByTrain : TravelMode
    {
        public TravelModeByTrain(double gramCO2PerKm) : base(gramCO2PerKm)
        {

        }
    }
}
