/*
 * Project : ParkingMeter
 * Author : Richard Aurélien
 * Description : A Parking Meter generating tickets
 * Version: 1.0.0
 * Creation Date : 13.06.2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter
{
    public class VanRate : VehicleRate
    {
        const decimal BASE_VAN_COST = 1.50M;
        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public VanRate(string pName, double pHeight) : base (pName, BASE_VAN_COST)
        {
            this.Height = pHeight;
        }

        /*
         * Name : ComputeParkingCost
         * Description : Calculate the cost of the parking. 
         *               If the van is taller than 1.8 meters, the cost is doubled.
         * Ext Params : - pBegin : DateTime
         *              - pDuration : int
         * Int Params : - CostForOneSlot : decimal
         * 
         * Returns : cost : decimal
         */
        override public decimal ComputeParkingCost(DateTime pBegin, int pDuration)
        {
            // if van is taller than 1.8 meters, cost doubled !
            if (this.Height > 1.8)
            {
                return (base.ComputeParkingCost(pBegin, pDuration) * 2);
            }
            
            return base.ComputeParkingCost(pBegin, pDuration); //default
        }
    }
}
