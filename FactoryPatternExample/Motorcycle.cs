using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Building a new Motorcycle");
        }
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving");
        }
    }
}
