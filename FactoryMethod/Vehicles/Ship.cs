using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Vehicles
{
    class Ship : IVehicle
    {
        public string Move()
        {
            return "The ship is floating";
        }
    }
}
