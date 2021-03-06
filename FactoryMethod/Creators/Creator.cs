﻿using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Creators
{
    abstract class Creator
    {
        public abstract Vehicle CreateVehicle();    // Factory method

        public string Launch()
        {
            var vehicle = CreateVehicle();
            return vehicle.Move();
        }
    }
}
