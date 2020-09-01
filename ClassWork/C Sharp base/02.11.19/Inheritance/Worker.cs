using System;

namespace Test
{
    public class Worker:Employee
    {
        public Worker(string name, DateTime birthday, string organization, DateTime hireDate):base(name,birthday,organization,hireDate,100)
        {
            
        }

        public void ExtraWork()
        {
            Console.WriteLine($"Worker {Name} is working hard after the end of day");
        }
        public sealed override void DoWork()
        {
            Console.WriteLine($"Worker {Name} is working hard");
        }
    }
}