using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Automobile : Transport
    {
        public string Brand { get; set; }
        public double Weight { get; set; }
        public double EngineCapacity { get; set; }
        public Automobile(string brand, double weight, double engine, int number) : base(number)
        {
            Brand = brand;
            Weight = weight;
            EngineCapacity = engine;
        }
        public override string Info()
        {
            return "Automobile\n" + 
                $"Brand: {Brand}\n" + 
                $"Weight: {Weight} kg\n" + 
                $"Engine capacity: {EngineCapacity}\n" + 
                $"Registration number: {RegistrationNumber}\n";
        }
    }
}
