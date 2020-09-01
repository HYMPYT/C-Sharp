using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    partial class Program
    {
        static void Main()
        {
            List<City> cities = new List<City>()
            {
                new City(){ Id = 1, CityName = "Dnepropetrovsk" },
                new City(){ Id = 2, CityName = "Kyiv" },
                new City(){ Id = 3, CityName = "Lvov" }
            };
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, FirstName = "Oleg", LastName = "Petrov", Age = 18, CityId = 3 },
                new Student(){ Id = 2, FirstName = "Marina", LastName = "Ivanova", Age = 19, CityId = 2 },
                new Student(){ Id = 3, FirstName = "Taras", LastName = "Golovko", Age = 19, CityId = 2 },
                new Student(){ Id = 4, FirstName = "Aleksei", LastName = "Smirnov", Age = 18, CityId = 1 },
                new Student(){ Id = 5, FirstName = "Oleg", LastName = "Belov", Age = 21, CityId = 1}
            };

            // 1 -> Запросы на сортировку:
            // ---------------------------
            Example1(students);
            // ---------------------------

            // 2 -> Запросы на группировку:
            // ----------------------------
            Example2(cities, students);
            // ----------------------------
        }

        private static void Example2(List<City> cities, List<Student> students)
        {
            var res1 = from student in students
                       group student by student.FirstName into gr
                       select new { Name = gr.Key, Count = gr.Count() };
            var res2 = from student in students
                       from city in cities
                       where student.CityId == city.Id
                       group city by city.CityName into gr
                       select new { cityName = gr.Key, cityCount = gr.Count() };

            Console.WriteLine("First result");
            foreach (var res in res1)
            {
                Console.WriteLine($"{res.Name} => {res.Count}");
            }

            Console.WriteLine("\nSecond result");
            foreach (var res in res2)
            {
                Console.WriteLine($"{res.cityName} => {res.cityCount}");
            }
        }

        private static void Example1(List<Student> students)
        {
            var res1 = students.OrderBy(x => x.FirstName);
            var res2 = students.OrderBy(x => x.LastName);
            var res3 = students.OrderBy(x => x.Age);
            var res4 = students.OrderByDescending(x => x.Age);
            var res5 = students.OrderBy(x => x.FirstName).ThenBy(y => y.LastName);

            int k = 0;
            Console.WriteLine("First result order by first name");
            foreach (var s in res1)
            {
                Console.WriteLine($"{++k}. {s}");
            }
            Console.WriteLine("\nSecond result order by last name");
            k = 0;
            foreach (var s in res2)
            {
                Console.WriteLine($"{++k}. {s}");
            }
            Console.WriteLine("\nThird result order by age");
            k = 0;
            foreach (var s in res3)
            {
                Console.WriteLine($"{++k}. {s}");
            }
            Console.WriteLine("\nThird result order by age");
            k = 0;
            foreach (var s in res3)
            {
                Console.WriteLine($"{++k}. {s}");
            }
            Console.WriteLine("\nFour result order by descending age");
            k = 0;
            foreach (var s in res4)
            {
                Console.WriteLine($"{++k}. {s}");
            }
            Console.WriteLine("\nFive result order by first name then by last name");
            k = 0;
            foreach (var s in res5)
            {
                Console.WriteLine($"{++k}. {s}");
            }
        }
    }
}
