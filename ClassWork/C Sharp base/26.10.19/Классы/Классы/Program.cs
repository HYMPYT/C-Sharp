using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    internal class Program
    {
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Group arr = new Group();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(arr[i]);
            }

            //string today = string.Format("Today is {0} {1} {2}", 26, "October", 2019);
            //Console.WriteLine(today);
            //Console.WriteLine("Sum -> " + Sum(12,23,345,45,4656,575,3,2,1,1));

            //int a = 3, b = 5;
            //Console.WriteLine($"{a} {b}");
            //Person.Swap(ref a, ref b);
            //Console.WriteLine($"{a} {b}");

            //Person.TestMethod();
            //Person a = new Person(birthday: new DateTime(day: 26, month: 10, year: 2000), name: "Yevhen");
            //Console.WriteLine(a);
            //Person b = new Person();
            //Console.WriteLine(b);
            //b.Name = "Masha";
            //Console.WriteLine(b);
            //a.LastName = "Ivanov";
            //Console.WriteLine(a);
        }
    }
}