using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_collector
{
    class TestClass : IDisposable
    {
        public string Name { get; set; }

        ~TestClass()
        {
            Console.WriteLine($"Finalise() -> {Name}");
            ReleaseUnmanagedResources();
        }
        private void ReleaseUnmanagedResources()
        {
            Console.WriteLine("Release Unmanaged Resources Here");
        }

        public void Dispose()
        {
            Console.WriteLine($"Dispose() -> {Name}");
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.MaxGeneration);
            Console.WriteLine(GC.CollectionCount(0));
            string str = "Hello";
            Console.WriteLine(GC.GetGeneration(str));
            double[] arr1 = new double[500];
            Console.WriteLine(GC.GetGeneration(arr1));
            GC.Collect(0);
            Console.WriteLine(GC.GetGeneration(arr1));
            double[] arr2 = new double[1000];
            Console.WriteLine(GC.GetGeneration(arr2));

            //using (var a = new TestClass { Name = "A" })
            //{
            //    Console.WriteLine(a.Name);
            //}
            ////TestClass a = new TestClass { Name = "A"};
            //if (true)
            //{
            //    TestClass b = new TestClass { Name = "B" };
            //}
            //Console.WriteLine("Some text");
        }
    }
}
//Рихтер