using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CargoAirplane : Plane
    {
        public double LoadCapacity { get; set; }
        public CargoAirplane(string thrustSource, int number, double loadCapacity) : base("Cargo", thrustSource, number)
        {
            LoadCapacity = loadCapacity;
        }
        public override string Info()
        {
            return "Cargo airplane\n" + $"Appointment: {Appointment}\n" +
                $"Thrust source: {ThrustSource}\n" +
                $"Load capacity: {LoadCapacity} t\n" +
                $"Registration number: {RegistrationNumber}\n";
        }
    }
}
