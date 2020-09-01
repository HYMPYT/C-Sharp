using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Plane : Transport
    {
        public string Appointment { get; set; }
        public string ThrustSource { get; set; }
        public Plane(string appointment, string thrustSource, int number) : base(number)
        {
            Appointment = appointment;
            ThrustSource = thrustSource;
        }
        public override string Info()
        {
            return "Plane\n" + $"Appointment: {Appointment}\n" +
                $"Thrust source: {ThrustSource}\n" +
                $"Registration number: {RegistrationNumber}\n";
        }
    }
}
