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
    class Ticket
    {
        private string _vehicleType;
        private DateTime _begin;
        private int _durationMinutes;
        private DateTime _end;
        private decimal _cost;



        private string VehicleType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
        }
        private DateTime Begin
        {
            get { return _begin; }
            set { _begin = value; }
        }
        private int DurationMinutes
        {
            get { return _durationMinutes; }
            set { _durationMinutes = value; }
        }
        private DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }
        private decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public Ticket(string pVehicleType, DateTime pBegin, int pDurationMinutes, DateTime pEnd, decimal pCost)
        {
            // Initialize Values
            this.VehicleType = pVehicleType;
            this.Begin = pBegin;
            this.DurationMinutes = pDurationMinutes;
            this.End = pEnd;
            this.Cost = pCost;
        }

        /*
         * Name : Display
         * Description : returns a string containing informations about the car, time, cost, etc.. 
         *               to be used by the view !
         * Ext Params : - NumberPlate : string
         * Int Params : - VehicleType : string
         *              - Begin : DateTime
         *              - End : DateTime
         *              - DurationMinutes : int
         *              - Cost : int
         * Returns : display : string
         */
        public string Display(string pNumberPlate)
        {
            // big string with all info
            return "véhicule : " + this.VehicleType + Environment.NewLine + "immatriculation : " 
                + pNumberPlate + Environment.NewLine + "début : " + this.Begin + Environment.NewLine + "fin : " + this.End
                + Environment.NewLine + "durée : " + this.DurationMinutes + " min " + Environment.NewLine + "coût : " + this.Cost + " CHF";
        }
    }
}
