using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Truck : Automobile
    {
        public double LoadCapacity { get; set; }
        public Truck(string brand, double weight, double engine, int number, double loadcapacity) : base(brand, weight, engine, number)
        {
            LoadCapacity = loadcapacity;
        }
        public override string Info()
        {
            return "Truck\n" + $"Brand: {Brand}\n" +
                $"Weight: {Weight} kg\n" +
                $"Engine capacity: {EngineCapacity}\n" +
                $"Registration number: {RegistrationNumber}\n" +
                $"Load capacity: {LoadCapacity} t\n";
        }
    }
}
