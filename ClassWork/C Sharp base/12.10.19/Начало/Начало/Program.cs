using System;
using System.Collections.Generic;

namespace Начало
{
    class Program
    {
        static bool ISPrime(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            string str = null;
            int? a = null;
            Nullable<int> b = null;
            int? c =  a ?? 50;


            //int a;
            //Console.Write("Enter the number -> ");
            //int.TryParse(Console.ReadLine(), out a);
            //if (ISPrime(a))
            //{
            //    Console.WriteLine("Prime number");
            //}
            //else
            //{
            //    Console.WriteLine("Not a prime");
            //}

            //string str = "Hello";
            //foreach(var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            //int a;
            //Console.Write("Enter the number -> ");
            //int.TryParse(Console.ReadLine(), out a);
            //switch(a)
            //{
            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    default:
            //        Console.WriteLine("Another number");
            //        break;
            //}

            //for(int i = 0; i< 10; i++)
            //{
            //    Console.Write((i + 1) + " ");
            //}
            //Console.WriteLine();

            //int a, b;
            //string buf;
            //Console.Write("Enter first number -> ");
            //buf = Console.ReadLine();
            //int.TryParse(buf, out a);
            //Console.Write("Enter second number -> ");
            //buf = Console.ReadLine();
            //int.TryParse(buf, out b);
            //int max = a > b ? a : b;
            //Console.WriteLine("Max = " + max);


            //int a;
            //string buf;
            //Console.Write("Enter number -> ");
            //buf = Console.ReadLine();
            //int.TryParse(buf, out a);
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            //int a, b;
            //string buf;
            //Console.Write("Enter first number -> ");
            //buf = Console.ReadLine();
            //int.TryParse(buf, out a);
            //Console.Write("Enter second number -> ");
            //buf = Console.ReadLine();
            //int.TryParse(buf, out b);
            //Console.WriteLine(a + " + " + b + " = " + (a + b));

            //Console.WriteLine("Hello Wolrd");
            ////Console.WriteLine("What is your name?");
            ////string name = Console.ReadLine();
            ////Console.WriteLine("Hello " + name + "!");
            //Console.WriteLine("How old are you?");
            //string buf = Console.ReadLine();
            ////int age = Convert.ToInt32(buf);
            ////int age = int.Parse(buf);
            //int age;
            //if (int.TryParse(buf, out age))
            //{
            //    Console.WriteLine(age + " is a great age!");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
        }
    }
}
/*
====ValueType
тип = структура
byte = Byte
int = Int32
short = Int16
long = Int64
float = Single
double = Double
decimal = Decimal
char = Char(2 байта)
bool = Boolean
====RValueType
тип = класс
Array
string = String (только для чтения)
*/
