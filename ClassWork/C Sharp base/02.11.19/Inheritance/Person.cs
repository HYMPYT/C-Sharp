using System;

namespace Test
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Birthday: {Birthday}";
        }
    }
}