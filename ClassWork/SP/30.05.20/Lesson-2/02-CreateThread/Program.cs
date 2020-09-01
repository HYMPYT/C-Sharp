using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_CreateThread
{
    class Program
    {
        private static void Method()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Culture Method Start: {Thread.CurrentThread.CurrentCulture.Name}");
            Console.WriteLine("Method Start");
            Thread.Sleep(10000);
            Console.WriteLine("Method End");
        }

        private static void ThreadFunc()
        {
            Console.WriteLine($"ID Вторичного потока: {Thread.CurrentThread.ManagedThreadId}");
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 320; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Вторичный поток завершился.");
        }
        static void Main(string[] args)
        {
            Method();
            ThreadFunc();
            Console.ReadKey();
        }
    }
}
