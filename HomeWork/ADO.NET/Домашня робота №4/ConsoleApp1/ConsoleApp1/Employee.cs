﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int DepId { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName,-20}\nSurname: {LastName,-20}\nAge: {Age,-3}";
        }
    }
}
