using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Операции над множествами в LINQ");

            int[] arr1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr2 = new int[5] { 30, 40, 50, 60, 70 };

            // 1 -> Concat
            // ----------------
            ConcatExample(arr1, arr2);
            // ----------------

            // 2 -> Union
            // ----------------
            UnionExample(arr1, arr2);
            // ----------------

            // 3 -> Intersect
            // ----------------
            IntersectExample(arr1, arr2);
            // ----------------

            // 4 -> Except-01
            // ----------------
            Except01Example(arr1, arr2);
            // ----------------

            // 5 -> Except-02
            // ----------------
            Except02Example(arr1, arr2);
            // ----------------

            // 6 -> Операторы преобразования:
            // ----------------
            OfTypeExample();
            ToArrayExample();
            List<City> cities = new List<City>
            {
                new City() {Id = 1, CityName = "Львов"},
                new City() {Id = 2, CityName = "Киев"},
                new City() {Id = 3, CityName = "Харьков"},
                new City() {Id = 4, CityName = "Днепр"},
                new City() {Id = 5, CityName = "Одесса"},
            };
            ToDictionaryExample(cities);
            // ----------------


        }

        private static void ToDictionaryExample(List<City> cities)
        {
            Dictionary<int, City> dict = cities.ToDictionary(x => x.Id);
            Console.WriteLine("\nToDictionary result");
            foreach (KeyValuePair<int, City> p in dict)
            {
                Console.WriteLine($"Key: {p.Key}; Id: {p.Value.Id}; Name: {p.Value.CityName}");
            }
        }

        private static void ToArrayExample()
        {
            IEnumerable<int> collection = new List<int> { 10, 20, 30, 40, 50 };
            int[] array = collection.ToArray();
            Console.WriteLine("\nToArray result");
            foreach (var x in array)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        private static void OfTypeExample()
        {
            Console.WriteLine("\nSixth result");
            ArrayList arr = new ArrayList() { 1, 2, 3, 4, "5", "6" };
            IEnumerable<int> res1 = arr.OfType<int>();
            foreach (var x in res1)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        private static void Except02Example(int[] arr1, int[] arr2)
        {
            var res1 = arr2.Except(arr1);

            Console.WriteLine("\nFiveth result union");
            foreach (var item in res1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static void Except01Example(int[] arr1, int[] arr2)
        {
            var res1 = arr1.Except(arr2);

            Console.WriteLine("\nFourth result union");
            foreach (var item in res1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static void IntersectExample(int[] arr1, int[] arr2)
        {
            var res1 = arr1.Intersect(arr2);

            Console.WriteLine("\nThird result union");
            foreach (var item in res1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static void UnionExample(int[] arr1, int[] arr2)
        {
            var res1 = arr1.Union(arr2);

            Console.WriteLine("\nSecond result union");
            foreach (var item in res1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static void ConcatExample(int[] arr1, int[] arr2)
        {
            var res1 = arr1.Concat(arr2);

            Console.WriteLine("First result concat");
            foreach (var item in res1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
