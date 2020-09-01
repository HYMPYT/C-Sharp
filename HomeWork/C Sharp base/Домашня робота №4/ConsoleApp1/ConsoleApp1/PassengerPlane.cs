using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PassengerPlane : Plane
    {
        public int NumberOfSeats { get; set; }
        public PassengerPlane(string thrustSource, int number, int numberOfSeats) : base("Passenger", thrustSource, number)
        {
            NumberOfSeats = numberOfSeats;
        }
        public override string Info()
        {
            return "Passenger " + base.Info() + $"Number of seats: {NumberOfSeats}\n";
        }
    }
}
