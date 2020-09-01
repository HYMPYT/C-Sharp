using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полиморфизм
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Birthday: {Birthday}\n";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Person))
                return false;
            return Name == ((Person)obj).Name && Birthday == ((Person)obj).Birthday;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Birthday.GetHashCode();
        }
    }
}
