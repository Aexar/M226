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
    class PMModel
    {
        private List<VehicleRate> _vehicleRates;
        private List<int> _availableDurations;
        private VehicleRate _currentVehicleRate;
        
        public List<VehicleRate> VehicleRates
        {
            get { return _vehicleRates; }
            set { _vehicleRates = value; }
        }
        public List<int> AvailableDurations
        {
            get { return _availableDurations; }
            set { _availableDurations = value; }
        }
        private VehicleRate CurrentVehicleRate
        {
            get { return _currentVehicleRate; }
            set { _currentVehicleRate = value; }
        }

        public PMModel()
        {
            // Initialize VehicleRates
            this.VehicleRates = new List<VehicleRate>();
            this.VehicleRates.Add(new MotorcycleRate("moto"));
            this.VehicleRates.Add(new CarRate("voiture"));
            this.VehicleRates.Add(new VanRate("camionnette basse (h = 1,8 m)", 1.8));
            this.VehicleRates.Add(new VanRate("camionnette haute (h = 2,2 m)", 2.2));

            // Initialize AvailableDurations
            this.AvailableDurations = new List<int>();
            this.AvailableDurations.Add(15);
            this.AvailableDurations.Add(30);
            this.AvailableDurations.Add(45);
            this.AvailableDurations.Add(60);
            this.AvailableDurations.Add(75);
            this.AvailableDurations.Add(90);
            this.AvailableDurations.Add(105);
            this.AvailableDurations.Add(120);

            // Initialize CurrentVehicleRate
            this.CurrentVehicleRate = null;
        }

        /*
         * Name : GenerateTicket
         * Description : gathers all infos from the form, then create a ticket !
         * Ext Params : - pVehicleIndex : int
         *              - pDurationIndex : int
         * Returns : Ticket
         */
        public Ticket GenerateTicket(int pVehicleIndex, int pDurationIndex)
        {
            // retrieve values from form
            CurrentVehicleRate = VehicleRates[pVehicleIndex];
            int duration = AvailableDurations[pDurationIndex];

            // Define dates
            DateTime begin = DateTime.Now;
            DateTime end = begin.AddMinutes(duration);

            // retrieve cost of CurrentVehicleRate
            decimal cost = CurrentVehicleRate.ComputeParkingCost(begin, duration);

            // Create ticket
            Ticket ticket = new Ticket(CurrentVehicleRate.Name, begin, duration, end, cost);

            return ticket;
        }
    }
}
