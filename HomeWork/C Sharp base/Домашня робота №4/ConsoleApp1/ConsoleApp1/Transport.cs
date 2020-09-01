using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Transport
    {
        public int RegistrationNumber { get; set; }
        public Transport(int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }
        public virtual string Info()
        {
            return "Transport\n" + $"Transport registration number: {RegistrationNumber}\n";
        }
    }
}
