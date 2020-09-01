using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department() { Id = 1, Country = "Ukraine", City = "Donetsk" },
                new Department() { Id = 2, Country = "Ukraine", City = "Kyiv" },
                new Department() { Id = 3, Country = "France", City = "Paris" },
                new Department() { Id = 4, Country = "Russia", City = "Moscow" }
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
                new Employee() { Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                new Employee() { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                new Employee() { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
                new Employee() { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                new Employee() { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 24, DepId = 2 },
                new Employee() { Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27, DepId = 4 }
            };

            Console.WriteLine("Task - 1");
            Console.WriteLine("=================================");
            Task1(departments, employees);
            Console.WriteLine("=================================");

            Console.WriteLine("\nTask - 2");
            Console.WriteLine("=================================");
            Task2(departments);
            Console.WriteLine("=================================");

            Console.WriteLine("\nTask - 3");
            Console.WriteLine("=================================");
            Task3(employees);
            Console.WriteLine("=================================");

            Console.WriteLine("\nTask - 4");
            Console.WriteLine("=================================");
            var result = from dep in departments
                         from emp in employees
                         where dep.Id == emp.DepId
                         where dep.City == "Kyiv"
                         where emp.Age > 23
                         select new
                         {
                             emp.FirstName,
                             emp.LastName,
                             emp.Age
                         };

            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.FirstName,-20}\nSurname: {emp.LastName,-20}\nAge: {emp.Age,-3}");
                Console.WriteLine();
            }
            Console.WriteLine("=================================");
        }

        private static void Task3(List<Employee> employees)
        {
            var result = (from emp in employees
                          where emp.Age > 25
                          select emp).Take(3);

            foreach (var emp in result)
            {
                Console.WriteLine(emp);
                Console.WriteLine();
            }
        }

        private static void Task2(List<Department> departments)
        {
            var result = (from dep in departments
                          select dep.Country).Distinct();
            foreach (var dep in result)
            {
                Console.WriteLine($"Country: {dep}");
                Console.WriteLine();
            }
        }

        private static void Task1(List<Department> departments, List<Employee> employees)
        {
            var result = from dep in departments
                         from emp in employees
                         where dep.Id == emp.DepId
                         where dep.Country == "Ukraine"
                         where dep.City != "Donetsk"
                         select new
                         {
                             emp.FirstName,
                             emp.LastName
                         };

            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.FirstName,-15}\nSurname: {emp.LastName,-15}");
                Console.WriteLine();
            }
        }
    }
}
