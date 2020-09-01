using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полиморфизм
{
    public sealed class Digger:Worker
    {
        public Digger(string name, DateTime birthday, string organization, DateTime hireDate) : base(name, birthday, organization, hireDate)
        {
            Salary = 150;
        }
        public new void DoWork()
        {
            Console.WriteLine($"Digger {Name} is digging the pits all day long");
        }
    }
}
