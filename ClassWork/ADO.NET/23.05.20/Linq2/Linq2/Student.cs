using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int CityId { get; set; }

        public override string ToString()
        {
            return $"{FirstName,-15}{LastName,-15}{Age,-5}{CityId,-5}";
        }
    }
}
