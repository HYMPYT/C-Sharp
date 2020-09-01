using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine("Method from class Point");
        }
        public int GetRandomNumber(double a, double b) => 21;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type pointType = typeof(Point);
            MethodInfo printMethod = pointType.GetMethod("Print");

            object pointObject = Activator.CreateInstance(pointType);

            printMethod.Invoke(pointObject, null);


            //PropertyInfo[] props = pointType.GetProperties();
            //foreach (var item in props)
            //{
            //    Console.WriteLine($"{item.Name}");
            //}

            //foreach (var method in pointType.GetMethods())
            //{
            //    Console.WriteLine($"{method.Name}");
            //}

            //foreach (var field in pointType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            //{
            //    Console.WriteLine($"{field.Name}");
            //}

            //foreach (var method in pointType.GetMethods())
            //{
            //    Console.Write($"{(method.IsPublic ? "public" : "private")}");
            //    string returnType = method.ReturnType.Name;
            //    Console.Write($" {returnType}");
            //    Console.Write($" {method.Name}(");

            //    foreach (var param in method.GetParameters())
            //    {
            //        Console.Write($"{param.ParameterType.Name} {param.Name}, ");
            //    }

            //    Console.Write($"\b\b);");

            //    Console.WriteLine();
            //}
        }
    }
}
