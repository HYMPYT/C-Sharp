using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_2.PS.Pagination.StrongTypeView.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student {Name = "Test1",  Lastname = "Klar1"},
                new Student {Name = "Test2",  Lastname = "Klar2"},
                new Student {Name = "Test3",  Lastname = "Klar3"},
                new Student {Name = "Test4",  Lastname = "Klar4"},
                new Student {Name = "Test5",  Lastname = "Klar5"},
                new Student {Name = "Test6",  Lastname = "Klar6"},
                new Student {Name = "Test7",  Lastname = "Klar7"},
                new Student {Name = "Test8",  Lastname = "Klar8"},
                new Student {Name = "Test9",  Lastname = "Klar9"},
                new Student {Name = "Test10", Lastname = "Klar10"}
            };
        }
    }
}