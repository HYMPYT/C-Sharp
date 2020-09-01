using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values1 = new int[5] { 1, 10, 5, 13, 4 };
            int[] values2 = new int[5] { 20, 1, 4, 9, 8 };

            Console.WriteLine("Task - 1");
            Console.WriteLine("===========================");
            //Task1(values1, values2);
            Console.WriteLine("===========================");

            Console.WriteLine("\nTask - 2");
            Console.WriteLine("===========================");
            //Task2(values1, values2);
            Console.WriteLine("===========================");

            Console.WriteLine("\nTask - 3");
            Console.WriteLine("===========================");
            //Task3(values1, values2);
            Console.WriteLine("===========================");

            Console.WriteLine("\nTask - 4");
            Console.WriteLine("===========================");
            //Task4(values1, values2);
            Console.WriteLine("===========================");

            Console.WriteLine("\nTask - 5");
            Console.WriteLine("===========================");
            //Task5(values1, values2);
            Console.WriteLine("===========================");
        }

        private static void Task3(int[] values1, int[] values2)
        {
            var result = values1.Intersect(values2).OrderByDescending(x => x).Take(1);

            foreach (var v in result)
            {
                Console.WriteLine($"Max: {v}\n");
            }
        }

        private static void Task5(int[] values1, int[] values2)
        {
            var result = values1.Concat(values2).OrderByDescending(x => x);

            foreach (var v in result)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
        }

        private static void Task4(int[] values1, int[] values2)
        {
            var result = values1.Concat(values2).Where(x => x >= 5 && x < 15).Sum();
            Console.WriteLine($"Sum: {result}\n");
        }

        private static void Task2(int[] values1, int[] values2)
        {
            var result = values1.Except(values2).Concat(values2.Except(values1));
            foreach (var v in result)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
        }

        private static void Task1(int[] values1, int[] values2)
        {
            var result = values1.Concat(values2).Where(x => x % 2 == 0 && x > 10).Average();
            Console.WriteLine($"Avarage: {result}");
        }
    }
}
