using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полиморфизм
{
    public class Manager : Employee
    {
        public Manager(string name, DateTime birthday, string organization, DateTime hireDate) : base(name, birthday, organization, hireDate, 500) { }
        public override void DoWork()
        {
            Console.WriteLine($"Manager {Name} is drinking coffee all day");
        }
        public void LookingToTheWindow()
        {
            Console.WriteLine($"Manager {Name} is looking to the main window");
        }
    }
}
