using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires do you want your new vehicle to have? 2 or 4.");
            var response = Console.ReadLine();
            var newVehicle = VehicleFactory.GetVehicle(response);
            newVehicle.Drive();

        }
    }
}
