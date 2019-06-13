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
    public class MotorcycleRate : VehicleRate
    {
        private const decimal DEFAULT_MOTO_COST = 0.75M;

        public MotorcycleRate(string pName) : base (pName, DEFAULT_MOTO_COST)
        {
            // NONE
        }
    }
}
