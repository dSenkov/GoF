using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Creators
{
    abstract class Creator
    {
        public abstract IVehicle CreateVehicle();

        public string Launch()
        {
            var vehicle = CreateVehicle();
            return vehicle.Move();
        }
    }
}
