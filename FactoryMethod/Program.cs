using FactoryMethod.Creators;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            LaunchVehicle(new TruckCreator());
            LaunchVehicle(new ShipCreator());
            LaunchVehicle(new PlaneCreator());

            Console.ReadKey();
        }

        static void LaunchVehicle(Creator creator)
        {
            Console.WriteLine(creator.Launch());
        }
    }
}
