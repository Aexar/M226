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
    public class VehicleRate
    {
        const int DEFAULT_SLOT_INTERVAL = 15;

        private string _name;
        private decimal _costForOneSlot;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal CostForOneSlot
        {
            get { return _costForOneSlot; }
            set { _costForOneSlot = value; }
        }

        public VehicleRate(string pName, decimal pCostForOneSlot)
        {
            this.Name = pName;
            this.CostForOneSlot = pCostForOneSlot;
        }

        /*
         * Name : ComputeParkingCost
         * Description : Calculate the cost of the parking. 
         *               Parking is free between 19h -> 6h !
         * Ext Params : - pBegin : DateTime
         *              - pDuration : int
         * Int Params : - CostForOneSlot : decimal
         * 
         * Returns : cost : decimal
         */
        virtual public decimal ComputeParkingCost(DateTime pBegin, int pDuration)
        {
            // if arrived between 19h00 (included) and 6h00 (excluded), parking free !
            if (pBegin.Hour < 6 || pBegin.Hour >= 19)
            {
                return 0;                
            }
            return (this.CostForOneSlot * (decimal)(pDuration/DEFAULT_SLOT_INTERVAL)); // base cost * nb of 15 min intervals (45 -> 3)

        }
    }
}
