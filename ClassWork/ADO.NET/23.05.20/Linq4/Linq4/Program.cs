using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 -> Поэлементные операторы LINQ:
            // =================================
            ElementOperatorsExample();
            // =================================

            // 2 -> Методы агрегирования данных:
            // ==================================
            DataAggregationMethodsExample();
            // ==================================

            // 3 -> Квантификаторы:
            // ==================================
            QuantifiersExample();
            // ==================================

            // 4 -> Генераторы коллекций:
            // ==================================
            CollectionGeneratorsExample();
            // ==================================
        }

        private static void CollectionGeneratorsExample()
        {
            // 4.1. - Empty
            Console.WriteLine("\nEmpty Example");
            IEnumerable<double> collection1 = Enumerable.Empty<double>();
            Console.WriteLine($"Count of Empty Collection -> {collection1.Count()}");

            // 4.2. Range
            Console.WriteLine("\nRange Example");
            IEnumerable<int> collection2 = Enumerable.Range(3, 5);
            foreach (var item in collection2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // 4.3. Repeat
            Console.WriteLine("\nRange Example");
            IEnumerable<int> collection3 = Enumerable.Repeat(3, 5);
            foreach (var item in collection3)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static void QuantifiersExample()
        {
            List<string> words = new List<string>()
            {
                "Door", "Room", "Dog", "Cat", "Flat", "Pen", "Dog", "Cat"
            };

            // 3.1. - Contains
            Console.WriteLine("\nContains Example");
            bool r1 = words.Contains("House");
            Console.WriteLine($"Result => {r1}");

            r1 = words.Contains("Pen");
            Console.WriteLine($"Result => {r1}");

            // 3.2. - Any
            Console.WriteLine("\nAny Example");
            bool r2 = words.Any(x => x == "Dog");
            Console.WriteLine($"Result => {r2}");

            r2 = words.Any(x => x.Length > 4);
            Console.WriteLine($"Result => {r2}");

            // 3.3. - All
            Console.WriteLine("\nAll Example");
            bool r3 = words.All(x => x.Length == 4);
            Console.WriteLine($"Result => {r3}");
        }

        private static void DataAggregationMethodsExample()
        {
            int[] A = new int[6] { 13, 4, 11, 12, 7, 9 };

            // 2.1. Count
            Console.WriteLine("\nCount Example");
            int k = A.Count(x => x % 2 != 0);
            Console.WriteLine($"k = {k}");

            // 2.2. Min
            Console.WriteLine("\nMin Example");
            k = A.Where(x => x % 2 != 0).Min();
            Console.WriteLine($"Min = {k}");

            // 2.3. Max
            Console.WriteLine("\nMax Example");
            k = A.Where(x => x % 2 != 0).Max();
            Console.WriteLine($"Max = {k}");

            // 2.4. Sum
            Console.WriteLine("\nMax Example");
            k = A.Where(x => x % 2 == 0).Sum();
            Console.WriteLine($"Sum = {k}");

            // 2.5. Avg
            Console.WriteLine("\nAvg Example");
            double avg = A.Average();
            Console.WriteLine($"Avg = {avg:f}");

            // 2.6. Aggregate
            Console.WriteLine("\nAggregate Example");
            int mult = A.Aggregate((x, y) => x * y);
            Console.WriteLine($"Mult = {mult}");
        }

        private static void ElementOperatorsExample()
        {
            List<Name> names = new List<Name>()
            {
                new Name() { Id = 1, RealName = "Alex"},
                new Name() { Id = 2, RealName = "Tamara"},
                new Name() { Id = 3, RealName = "Stas"},
                new Name() { Id = 4, RealName = "Alex"},
                new Name() { Id = 5, RealName = "Alena"},
                new Name() { Id = 6, RealName = "Alex"},
                new Name() { Id = 7, RealName = "Boris"}
            };
            // 1.1.
            Console.WriteLine("First Example");
            int id = names.First(x => x.RealName == "Alex").Id;
            Console.WriteLine($"Id of Alex -> {id}");

            // 1.2.
            Console.WriteLine("\nLast Example");
            id = names.Last(x => x.RealName == "Alex").Id;
            Console.WriteLine($"Id of Alex -> {id}");

            // 1.3.
            Console.WriteLine("\nFirstOrDefault Example");
            string name = "Barak";
            var res = names.FirstOrDefault(x => x.RealName == name);
            if (res == null)
                Console.WriteLine($"Name {name} not found");
            else
                Console.WriteLine($"Id of Barak -> {res.Id}");

            // 1.4.
            Console.WriteLine("\nSingle Example");
            id = names.Single(x => x.RealName == "Tamara").Id;
            Console.WriteLine($"Id of Tamara -> {id}");

            // 1.5.
            try
            {
                id = names.Single(x => x.RealName == "Alex").Id;
                Console.WriteLine($"Id of Alex -> {id}");
            }
            catch (InvalidOperationException err)
            {
                Console.WriteLine(err.Message);
            }

            // 1.6. - LastOrDefault
            // 1.7. - SingleOrDefault

            // 1.8. - ElementAt():
            Console.WriteLine("\nElementAt Example");
            Name n = names.ElementAt(4);
            Console.WriteLine($"{n.Id} => {n.RealName}");
        }
    }
}
