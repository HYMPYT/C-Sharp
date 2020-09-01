using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PassengerAuto : Automobile
    {
        public int NumberOfSeats { get; set; }
        public PassengerAuto(string brand, double weight, double engine, int number, int seats) : base(brand, weight, engine, number)
        {
            NumberOfSeats = seats;
        }
        public override string Info()
        {
            return "Passenger " + base.Info() + $"Number of seats: {NumberOfSeats}\n";
        }
    }
}
