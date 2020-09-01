using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Random rnd = new Random();
            Student student = new Student("Ivan", "Petrushska", "Olegovuch", "KV-83", 23, 6, 3, 4);
            //Console.WriteLine("Enter the marks of programming:");
            for (int i = 0; i < 6; i++)
            {
                student[0, i] = rnd.Next(7, 13);
            }
            //Console.WriteLine("Enter the marks of administration:");
            for (int i = 0; i < 3; i++)
            {
                student[1, i] = rnd.Next(7, 13);
            }
            //Console.WriteLine("Enter the marks of design:");
            for (int i = 0; i < 4; i++)
            {
                student[2, i] = rnd.Next(7, 13);
            }
            Console.WriteLine(student.ToString());

            //=============================================

            //2
            //Random rnd = new Random();
            //int[,] arr = new int[4, 3];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rnd.Next(1, 6);
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("==============================");
            //int[,]trans = Mathematical.Transpose(arr);
            //for (int i = 0; i < trans.GetLength(0); i++)
            //{
            //    for (int j = 0; j < trans.GetLength(1); j++)
            //    {
            //        Console.Write(trans[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //double a = 5, b = 30;
            //Console.WriteLine($"Расчет экспоненциальной функции -> {Mathematical.exp(a)}");
            //Console.WriteLine($"Арксинус заданного аргумента -> {Mathematical.arcsin(b)}");
            //Console.WriteLine($"Расстояние между двумя точками в трехмерном пространстве -> {Mathematical.distanceBetweenPoints(2, 4, 0, 5, -1, 6)}");
        }
    }
}