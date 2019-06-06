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
    class CFCModel
    {

        private List<Destination> _destinations;
        private TravelModeByPlane _travelModeByPlane;
        private TravelModeByTrain _travelModeByTrain;
        public List<Destination> Destinations
        {
            get { return _destinations; }
            set { _destinations = value; }
        }
        public TravelModeByPlane TravelModeByPlane
        {
            get { return _travelModeByPlane; }
            set { _travelModeByPlane = value; }
        }
        public TravelModeByTrain TravelModeByTrain
        {
            get { return _travelModeByTrain; }
            set { _travelModeByTrain = value; }
        }

        public CFCModel()
        {
            // Initialize Destinations
            this.Destinations = new List<Destination>();
            this.Destinations.Add(new Destination("Barcelone", 623));
            this.Destinations.Add(new Destination("Lisbonne", 1500));
            this.Destinations.Add(new Destination("Londres", 746));
            this.Destinations.Add(new Destination("Paris", 410));
            this.Destinations.Add(new Destination("Zurich", 277));

            // Initialize TravelModeByPlane
            this.TravelModeByPlane = new TravelModeByPlane(285.0);

            // Initialize TravelModeByTrain
            this.TravelModeByTrain = new TravelModeByTrain(14.0);


        }
        /*
         * Name : GetDistanceFromGeneva
         * Desc : Get the distance between geneva and given city
         */
        private int GetDistanceFromGeneva(string city)
        {
            int distance = 0;

            // search the city and return the distance
            this.Destinations.ForEach(delegate (Destination destination)
            {
                if (destination.City == city)
                {
                    distance = destination.DistanceFromGeneva;
                }
            });

            if (distance == 0)
            {
                throw new ArgumentException();
            }
            return distance;
        }

        /*
         * Name : getCarbonFootprintByPlane
         * Desc : Compute how much grams of CO2 got emitted by plane
         */
        public double GetCarbonFootprintByPlane(string city, string travelClass)
        {
            // Retrieve the distance
            int distance = GetDistanceFromGeneva(city);
            
            // Calculate CO2 footprint
            double footprintCO2 = this.TravelModeByPlane.ComputeCarbonFootprint(distance,travelClass);

            // return
            return footprintCO2;
        }

        /*
         * Name : GetCarbonFootprintByTrain
         * Desc : Compute how much grams of CO2 got emitted by train
         */
        public double GetCarbonFootprintByTrain(string city)
        {
            // Retrieve the distance
            int distance = GetDistanceFromGeneva(city);

            // Calculate CO2 footprint
            double footprintCO2 = this.TravelModeByTrain.ComputeCarbonFootprint(distance);

            // return
            return footprintCO2;
        }
            

    }
}
