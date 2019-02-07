using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Vehicles
{
    class Truck : IVehicle
    {
        public string Move()
        {
           return "The truck is riding";
        }
    }
}
