using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Vehicles;

namespace FactoryMethod.Creators
{
    class TruckCreator : Creator
    {
        public override Vehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
