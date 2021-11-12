using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Building a new Car");
        }
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving");
        }
    }
}
