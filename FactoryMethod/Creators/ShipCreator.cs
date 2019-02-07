using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Vehicles;

namespace FactoryMethod.Creators
{
    class ShipCreator : Creator
    {
        public override Vehicle CreateVehicle()
        {
            return new Ship();
        }
    }
}
