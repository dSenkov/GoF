using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Vehicles;

namespace FactoryMethod.Creators
{
    class TruckCreator : Creator
    {
        public override IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
