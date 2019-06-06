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
    class Destination
    {
        const string DEFAULT_CITY = "Zurich";
        const int DEFAULT_DISTANCE = 277;

        private string _city;
        private int _distanceFromGeneva;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }


        public int DistanceFromGeneva
        {
            get { return _distanceFromGeneva; }
            set { _distanceFromGeneva = value; }
        }


        public Destination(string city, int distanceFromGeneva)
        {
            this.City = city;
            this.DistanceFromGeneva = distanceFromGeneva;
        }
        public Destination() : this(DEFAULT_CITY, DEFAULT_DISTANCE)
        {
            // NONE
        }
    }
}
