using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полиморфизм
{
    public abstract class Employee : Person
    {
        public double Salary { get; set; }
        public string Organization { get; set; }
        public DateTime HireDAte { get; set; }

        public Employee(string name, DateTime birthday, string organization, DateTime hireDate, double salary)
        {
            Name = name;
            Birthday = birthday;
            Organization = organization;
            HireDAte = hireDate;
            Salary = salary;
        }
        public abstract void DoWork();
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Birthday: {Birthday.ToLongDateString()}\n" +
                $"Organization: {Organization}\n" +
                $"Hire date: {HireDAte.ToLongDateString()}\n" +
                $"Salary: {Salary}\n";
        }
    }
}
