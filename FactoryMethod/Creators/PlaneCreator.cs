using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Vehicles;

namespace FactoryMethod.Creators
{
    class PlaneCreator : Creator
    {
        public override Vehicle CreateVehicle()
        {
            return new Plane();
        }
    }
}
