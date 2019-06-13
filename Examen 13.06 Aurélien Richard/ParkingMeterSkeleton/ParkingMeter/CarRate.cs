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
    class CarRate : VehicleRate
    {
        private const decimal DEFAULT_CAR_COST = 1.00M;
        public CarRate(string pName) : base(pName, DEFAULT_CAR_COST)
        {
            // NONE
        }
    }
}
