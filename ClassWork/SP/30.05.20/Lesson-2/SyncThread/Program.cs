using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncThread
{
    class MyCounter
    {
        // для блокировки
        private object locker = new object();
        int count;
        int countEven;
        public int Count
        {
            get { return count; }
        }

        public int CountEven { get => countEven; }
        public void UpdateFields()
        {
            for (int i = 0; i < 1000000; ++i)
            {
                //++count;
                //if (i % 2 == 0)
                //    ++countEven;
                // 1. Cпособ синхронизации
                //Interlocked.Increment(ref count);
                //if (i % 2 == 0)
                //    Interlocked.Increment(ref countEven);
                // 2. Cпособ синхронизации Monitor
                //try
                //{
                //    Monitor.Enter(locker);
                //    ++count;
                //}
                //finally
                //{
                //    Monitor.Exit(locker);
                //}



                // 3. Cпособ синхронизации lock
                lock (locker)
                {
                    ++count;
                    if (i % 2 == 0)
                        ++countEven;
                }
            }
        }
    }
    class Program
    {
        static int Sum(int a, int b)
        {
            Thread.Sleep(3000);
            return a + b;
        }
        static void Main(string[] args)
        {
            int a = 21, b = 33;
            Thread thread = new Thread(() =>
            {
                int result = Sum(a, b);
                Console.WriteLine($"Result = {result}");
            });
            thread.Start();

            MyCounter counter = new MyCounter();
            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(counter.UpdateFields);
                threads[i].Start();
                //threads[i].Join();
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Count = {counter.Count}");
            Console.WriteLine($"Count even = {counter.CountEven}");
        }
    }
}
