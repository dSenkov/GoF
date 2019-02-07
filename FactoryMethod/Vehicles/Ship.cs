using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Vehicles
{
    class Ship : Vehicle
    {
        public string Move()
        {
            return "The ship is floating";
        }
    }
}
