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
            //int size_mas;
            //Console.Write("Enter the size of massive -> ");
            //size_mas = Int32.Parse(Console.ReadLine());
            //Shop arr = new Shop(size_mas);
            //string brand, country;
            //double diagonal, weight;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter product brand -> ");
            //    brand = Console.ReadLine();
            //    Console.Write("Enter the diagonal of the product screen -> ");
            //    diagonal = Double.Parse(Console.ReadLine());
            //    Console.Write("Enter the weight of the product -> ");
            //    weight = Double.Parse(Console.ReadLine());
            //    Console.Write("Enter the producing country -> ");
            //    country = Console.ReadLine();
            //    arr[i] = new Laptop(brand, diagonal, weight, country);
            //}
            Shop arr = new Shop();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("==================================");
                Console.WriteLine(arr[i]);
            }
        }
    }
}
