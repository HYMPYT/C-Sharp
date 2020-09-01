using System;

namespace Test
{
    public abstract class Employee : Person
    {
        public double Salary { get; set; }
        public string Organization { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, DateTime birthday, string organization, DateTime hireDate, double salary)
        {
            Name = name;
            Birthday = birthday;
            Organization = organization;
            HireDate = hireDate;
            Salary = salary;
        }

        public abstract void DoWork();
        
        public override string ToString()
        {
            return $"Name = {Name}\n" +
                   $"Birthday = {Birthday.ToLongDateString()}\n" +
                   $"Organization = {Organization}\n" +
                   $"HireDate = {HireDate.ToLongDateString()}\n" +
                   $"Salary = {Salary}\n";
        }
    }
}