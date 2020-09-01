using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полиморфизм
{
    public class Worker : Employee
    {
        public Worker(string name, DateTime birthday, string organization, DateTime hireDate) : base(name, birthday, organization, hireDate, 100) { }
        public sealed override void DoWork()
        {
            Console.WriteLine($"Worker {Name} is working hard");
        }
        public void ExtraWork()
        {
            Console.WriteLine($"Worker {Name} is working hard after the end of day");
        }
    }
}
