using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student {Id = 1, Name = "Игорь", LastName = "Перепечкин"},
                new Student {Id = 2, Name = "Олег", LastName = "Лазуткин"},
                new Student {Id = 3, Name = "Андрей", LastName = "Хаустович"},
                new Student {Id = 4, Name = "Надежда", LastName = "Полюхович"},
            };
        }
    }
}