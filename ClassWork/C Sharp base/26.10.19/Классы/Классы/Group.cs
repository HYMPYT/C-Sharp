using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    class Group
    {
        private Person[] _arr = new Person[5];

        public Group()
        {
            _arr = new Person[5]
            {
                new Person("Masha", new DateTime(2000, 3, 7)),
                new Person("Petya", DateTime.Parse("25.5.2001")),
                new Person("Ivan", new DateTime(2012, 11, 7)),
                new Person("Sveta", new DateTime(2005, 3, 23)),
                new Person("Natasha", new DateTime(1999, 6, 17)),
            };
        }
        public int Length => _arr.Length;
        public Person this [int index]
        {
            get => _arr[index];
            set => _arr[index] = value;
        }
    }
}
