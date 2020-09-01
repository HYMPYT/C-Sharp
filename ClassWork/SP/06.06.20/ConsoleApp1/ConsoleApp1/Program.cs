using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class TaskVoidTest
    {
        public static void Print(string str = "")
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{str}Thread{Thread.CurrentThread.ManagedThreadId}# {i}");
                //Thread.Sleep(200);
            }
        }
        public static void Test()
        {
            Task Task1 = new Task(() => Print(""));
            Task Task2 = new Task(() => Print("\t\t"));


            Task1.Start();
            Task2.Start();

            Task.WaitAll(Task1, Task2);
        }
    }

    class TaskReturnTest
    {
        static int Fact(int n)
        {
            Thread.Sleep(1000);
            if (n == 0)
            {
                return 1;
            }
            return n * Fact(n - 1);
        }

        static Task<int> FactAsync(int n)
        {
            return Task.Factory.StartNew(() => Fact(n));
        }

        public static void Test()
        {
            Task<int> result = FactAsync(6);
            result.ContinueWith((t) =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"result = {result.Result}");
            });

            while (true)
            {
                Console.WriteLine("-----------------------");
                Thread.Sleep(200);
            }

        }
    }

    class TaskCancellationTokenSimple
    {
        private static CancellationToken token;
        private static CancellationTokenSource CancellationTokenSource;
        static TaskCancellationTokenSimple()
        {
            CancellationTokenSource = new CancellationTokenSource();
            token = CancellationTokenSource.Token;
        }
        public static void Print()
        {
            while (true)
            {
                //if (token.IsCancellationRequested)
                //    break;
                try
                {
                    token.ThrowIfCancellationRequested();
                }
                catch (OperationCanceledException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cancellation requested");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    CancellationTokenSource = new CancellationTokenSource();
                    token = CancellationTokenSource.Token;
                }
                Console.WriteLine("Hello world");
                Thread.Sleep(300);
            }
        }
        public static void Start()
        {
            Task t = new Task(() => Print());
            t.Start();
            while (true)
            {
                Console.ReadKey();
                CancellationTokenSource.Cancel();
            }
        }
    }

    class TaskReturnAsyncAwaitTest
    {
        static int Fact(int n)
        {
            Thread.Sleep(1000);
            if (n == 0)
            {
                return 1;
            }
            return n * Fact(n - 1);
        }
        static Task<int> FactAsync(int n)
        {
            return Task.Factory.StartNew(() => Fact(n));
        }
        static async void PrintFact()
        {
            int result = await FactAsync(6);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"result = {result}");
        }
        public static void Test()
        {
            PrintFact();

            while (true)
            {
                Console.WriteLine("-----------------------");
                Thread.Sleep(200);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //TaskReturnTest.Test();
            //TaskCancellationTokenSimple.Start();
            TaskReturnAsyncAwaitTest.Test();
        }
    }
}
