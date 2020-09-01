using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Good> goods1 = new List<Good>()
            {
                new Good() { Id = 1, Title = "Nokia 1100", Price = 450.99, Category = "Mobile" },
                new Good() { Id = 2, Title = "Iphone 4", Price = 5000, Category = "Mobile" },
                new Good() { Id = 3, Title = "Refregirator 5000", Price = 2555, Category = "Kitchen" },
                new Good() { Id = 4, Title = "Mixer", Price = 150, Category = "Kitchen" },
                new Good() { Id = 5, Title = "Magnitola", Price = 1499, Category = "Car" }
            };

            List<Good> goods2 = new List<Good>()
            {
                new Good() { Id = 6, Title = "Samsung Galaxy", Price = 3100, Category = "Mobile" },
                new Good() { Id = 7, Title = "Auto Cleaner", Price = 2300, Category = "Car" },
                new Good() { Id = 8, Title = "Owen", Price = 700, Category = "Kitchen" },
                new Good() { Id = 9, Title = "Siemens Turbo", Price = 3199, Category = "Mobile" },
                new Good() { Id = 10, Title = "Lighter", Price = 150, Category = "Car" }
            };

            var goods = goods1.Concat(goods2).ToList();

            Console.WriteLine("Task - 1");
            Console.WriteLine("============================");
            //Task1(goods);
            Console.WriteLine("============================");

            Console.WriteLine("\nTask - 2");
            Console.WriteLine("============================");
            //Task2(goods);
            Console.WriteLine("============================");

            Console.WriteLine("\nTask - 3");
            Console.WriteLine("============================");
            //Task3(goods);
            Console.WriteLine("============================");

            Console.WriteLine("\nTask - 4");
            Console.WriteLine("============================");
            //Task4(goods);
            Console.WriteLine("============================");

            Console.WriteLine("\nTask - 5");
            Console.WriteLine("============================");
            //Task5(goods);
            Console.WriteLine("============================");

            Console.WriteLine("\nTask - 6");
            Console.WriteLine("============================");
            //Task6(goods1, goods2);
            Console.WriteLine("============================");

            Console.WriteLine("\nTask - 7");
            Console.WriteLine("============================");
            //Task7(goods);
            Console.WriteLine("============================");

            Console.WriteLine("\nTask - 8");
            Console.WriteLine("============================");
            //Task8(goods);
            Console.WriteLine("============================");

            Console.WriteLine("\nTask - 9");
            Console.WriteLine("============================");
            //Task9(goods);
            Console.WriteLine("============================");

            Console.WriteLine("\nTask - 10");
            Console.WriteLine("============================");
            //Task10(goods);
            Console.WriteLine("============================");
        }

        private static void Task6(List<Good> goods1, List<Good> goods2)
        {
            var result = from g1 in goods1
                         from g2 in goods2
                         where g1.Price == g2.Price
                         select new
                         {
                             Title1 = g1.Title,
                             Title2 = g2.Title,
                             g1.Price
                         };

            foreach (var g in result)
            {
                Console.WriteLine($"Title 1: {g.Title1}\nTitle 2: {g.Title2}\nPrice: {g.Price}");
                Console.WriteLine();
            }
        }

        private static void Task9(List<Good> goods)
        {
            var result = ((from g in goods
                           where g.Category == "Car"
                           select g).Concat(from g in goods
                                            where g.Category == "Mobile"
                                            select g)).Count();

            Console.WriteLine($"Sum: {result}\n");
        }

        private static void Task10(List<Good> goods)
        {
            var result = from g in goods
                         group g by g.Category into gr
                         select new
                         {
                             Category = gr.Key,
                             NumberOfGoods = gr.Count()
                         };

            foreach (var g in result)
            {
                Console.WriteLine($"Category: {g.Category}\nNumber of goods: {g.NumberOfGoods}");
                Console.WriteLine();
            }
        }

        private static void Task8(List<Good> goods)
        {
            var result = (from g in goods
                          where g.Category == "Car"
                          select g).Any(x => x.Price >= 1000 && x.Price < 2000);

            Console.WriteLine($"Result: {result}");
        }

        private static void Task7(List<Good> goods)
        {
            var result = from g in goods
                         orderby g.Title
                         select new
                         {
                             g.Title,
                             g.Category
                         };

            foreach (var g in result)
            {
                Console.WriteLine($"Title: {g.Title}\nCategory: {g.Category}");
                Console.WriteLine();
            }
        }

        private static void Task5(List<Good> goods)
        {
            var result = (from g in goods
                          select g.Category).Distinct();

            foreach (var g in result)
            {
                Console.WriteLine($"Category: {g}");
                Console.WriteLine();
            }
        }

        private static void Task4(List<Good> goods)
        {
            var result = (from g in goods
                          select g.Price).Average();
            Console.WriteLine($"Avarage: {result}\n");
        }

        private static void Task3(List<Good> goods)
        {
            var result = (from g in goods
                          orderby g.Price descending
                          select new
                          {
                              g.Title,
                              g.Category
                          }).Take(1);

            foreach (var g in result)
            {
                Console.WriteLine($"Title: {g.Title}\nCategory: {g.Category}");
                Console.WriteLine();
            }
        }

        private static void Task2(List<Good> goods)
        {
            var result = from g in goods
                         where g.Category != "Kitchen"
                         where g.Price > 1000
                         select new
                         {
                             g.Title,
                             g.Price
                         };
            foreach (var g in result)
            {
                Console.WriteLine($"Title: {g.Title}\nPrice: {g.Price}");
                Console.WriteLine();
            }
        }

        private static void Task1(List<Good> goods)
        {
            var result = from g in goods
                         where g.Price > 1000
                         where g.Category == "Mobile"
                         select g;

            foreach (var g in result)
            {
                Console.WriteLine(g);
                Console.WriteLine();
            }
        }
    }
}
