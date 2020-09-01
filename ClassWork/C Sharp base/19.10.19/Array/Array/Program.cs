using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Масив
{
    class Program
    {
        static int CompareArray(int[] a, int[] b)
        {
            return a.Length - b.Length;
        }
        static void Main(string[] args)
        {
            int a = 3, b = 5;
            Console.WriteLine(a+" "+b);
            (a, b) = (b, a);
            Console.WriteLine(a + " " + b);

            //Random rnd = new Random();
            //Console.Write("Enter the size -> ");
            //int row = Int32.Parse(Console.ReadLine());
            //int[][] arr = new int[row][];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new int[rnd.Next(3, 15)];
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        arr[i][j] = rnd.Next(20, 58);
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Array.Sort(arr, CompareArray);
            //Console.WriteLine();
            //foreach (var line in arr)
            //{
            //    foreach (var item in line)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("SUM -> " + arr[0].Sum());

            //Random rnd = new Random();
            //int[,] arr = new int[4, 5];
            //for(int i = 0; i<arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j< arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rnd.Next(10);
            //    }
            //}
            //for(int i = 0; i< arr.Length; i++)
            //{
            //    Console.Write(arr[i / 5, i % 5] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] arr = new int[10];
            //Random rnd = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(15, 31);
            //}
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(Array.BinarySearch(arr, 23));
            //Console.WriteLine(Array.IndexOf(arr, 23));
        }
    }
}
