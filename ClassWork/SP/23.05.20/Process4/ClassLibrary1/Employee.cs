using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable]
    public class Employee : Person
    {
        string position;
        decimal salary;
        public Employee(string name, string lastName, int age, string position, decimal salary) : base(name, lastName, age)
        {
            this.position = position;
            this.salary = salary;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"\nPosition: {position}\nSalary: {salary}");
        }
    }
}
