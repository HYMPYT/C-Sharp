using System;

namespace Test
{
    public class Manager:Employee
    {
        public Manager(string name, DateTime birthday, string organization, DateTime hireDate):base(name,birthday,organization,hireDate,500)
        {
            
        }

        public void LookingToTheWindow()
        {
            Console.WriteLine($"Manager {Name} is looking to the main window");
        }
        public override void DoWork()
        {
            Console.WriteLine($"Manager {Name} is drinking coffee all day");
        }
    }
}