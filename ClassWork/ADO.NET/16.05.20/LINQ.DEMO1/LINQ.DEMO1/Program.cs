using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.DEMO1
{
    class Program
    {
        static void Example1(List<Student> students)
        {
            var res1 = from s in students
                       where (s.Age > 18 && s.FirstName == "Vasya")
                       select s;


            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");

            var res2 = students.Where(s => s.Age >= 18 && s.FirstName == "Sidor").OrderBy(s => s.Id).ToList();

            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
        }

        static void Example2(List<Student> students)
        {
            var res1 = (from s in students
                        where s.FirstName != "Vasya"
                        where s.FirstName != "Sidor"
                        select s).Take(3);

            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");

            var res2 = students.Where(s => s.FirstName != "Vasya" && s.FirstName != "Sidor").Take(3).ToList();
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
        }

        static void Example3(List<Student> students)
        {
            var res = students.Skip(3).ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
        }

        static void Example4(List<Student> students)
        {
            var res = students.Skip(2).Take(3).ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
        }

        static void Example5(List<Student> students)
        {
            var res = students.Skip(1).TakeWhile(s => s.FirstName == "Vasya");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "Sidor", "Ivanov", 21),
                new Student(2, "Vasya", "Petrov", 19),
                new Student(3, "Fedor", "Sidorov", 27),
                new Student(4, "Andrey", "Adreev", 24),
                new Student(5, "Sergey", "Sergeev", 45),
                new Student(6, "Sidor", "Fedorov", 18),
                new Student(7, "Vasya", "Pupkin", 35)
            };
            Console.WriteLine("Example 1");
            Example1(students);
            Console.WriteLine("Example 2");
            Example2(students);
            Console.WriteLine("Example 3");
            Example3(students);
            Console.WriteLine("Example 4");
            Example4(students);
            Console.WriteLine("Example 5");
            Example5(students);
        }
    }
}
