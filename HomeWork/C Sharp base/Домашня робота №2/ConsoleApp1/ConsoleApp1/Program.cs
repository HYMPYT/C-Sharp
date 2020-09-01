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
            Random rd = new Random();

            //1

            //int[] arr = new int[10];
            //int buf = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rd.Next(0, 4);
            //}
            //Console.Write("First Array -> ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    if (arr[i] == 0 && i == arr.Length - 1)
            //    {
            //        continue;
            //    }
            //    if (arr[i] == 0)
            //    {
            //        for (int j = i; j < arr.Length - 1; j++)
            //        {
            //            buf = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = buf;
            //        }
            //    }
            //}
            //Console.Write("Second Array -> ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    if (arr[i] == 0)
            //        arr[i] = -1;
            //}
            //Console.Write("Final Array -> ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();




            //2 Вариант с нулями

            //int[] arr = new int[20];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rd.Next(-5, 6);
            //}
            //Console.Write("First Array -> ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //Array.Sort(arr);
            //Console.Write("Second Array -> ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();


            //2 Вариант без нулей

            //int[] arr = new int[20];
            //int buf = 0, count_z = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rd.Next(-1, 2);
            //}
            //Console.Write("First array -> ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //Array.Sort(arr);
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    if (arr[i] == 0 && i == arr.Length - 1)
            //    {
            //        continue;
            //    }
            //    if (arr[i] == 0)
            //    {
            //        for (int j = i; j < arr.Length - 1; j++)
            //        {
            //            buf = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = buf;
            //        }
            //    }
            //}
            //Console.Write("Second array -> ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    if (arr[i] != 0)
            //        break;
            //    count_z++;
            //}
            //Array.Resize<int>(ref arr, 20 - count_z);
            //Console.Write("Final array -> ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();




            //3
            //int rows, columns, a, b, buf;
            //Console.Write("Enter the rows -> ");
            //rows = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter the columns -> ");
            //columns = Int32.Parse(Console.ReadLine());
            //int[,] arr = new int[rows, columns];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rd.Next(10);
            //    }
            //}
            //Console.WriteLine("First Array:");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("Enter the number of first column -> ");
            //a = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter the number of second column -> ");
            //b = Int32.Parse(Console.ReadLine());
            //for (int j = 0; j < arr.GetLength(1); j++)
            //{
            //    if (j == a)
            //    {
            //        for (int i = 0; i < arr.GetLength(0); i++)
            //        {
            //            buf = arr[i, j];
            //            arr[i, j] = arr[i, b];
            //            arr[i, b] = buf;
            //        }
            //        break;
            //    }
            //}
            //Console.WriteLine("Second Array:");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}