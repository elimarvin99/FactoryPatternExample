using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}

