using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)     //IVehicle is the return type
        {
            switch (vehicleType.ToLower())
            {
                case "2":
                case "two":
                    return new Motorcycle();
                    //we can't add break because return breaks/ends the method
                case "4":
                case "four":
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}

