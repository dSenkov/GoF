using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Vehicles
{
    class Plane : IVehicle
    {
        public string Move()
        {
            return "The plane is flying";
        }
    }
}
