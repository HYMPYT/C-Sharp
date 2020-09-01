using System;

namespace Test
{
    public sealed class Digger:Worker
    {
        public Digger() : base("Digger", DateTime.Now, "HomeSweetHome", DateTime.Now)
        {
            Salary = 150;
        }

        public new void DoWork()
        {
            Console.WriteLine($"Digger {Name} is digging the the pits all day long");
        }
    }
}