using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Исключения
{
    class Program
    {
        private static int Input()
        {
            return Int32.Parse(Console.ReadLine());
        }
        private static int Calc(out int a, out int b)
        {
            try
            {
                Console.WriteLine("Enter the first number -> ");
                a = Input();
                Console.WriteLine("Enter the second number -> ");
                b = Input();

                return a / b;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                throw new FormatException("AAAAAAAAAA", e);
            }
        }
        static void Main(string[] args)
        {
            int a = 2000000000;
            int c = 0;
            unchecked
            {
                try
                {
                    c = a + 1000000000;
                }
                catch(Exception e)
                {
                    c = -111;
                }
            }
            Console.WriteLine(c);

            //int a, b;
            //try
            //{
            //    int c = Calc(out a, out b);
            //    Console.WriteLine(c);
            //}
            //catch (SystemException e) when (e.Message == "AAAAAAAAAA")
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine($"Error: {e.TargetSite.Name}");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine($"Error: {e.TargetSite.Name}");
            //    Console.WriteLine($"Error: {e.InnerException?.TargetSite.Name}");
            //    Console.WriteLine($"Error: {e.Message}");
            //    Console.WriteLine($"Error: {e.InnerException?.Message}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            ////catch
            ////{
            ////    Console.WriteLine("Error");
            ////}
            //finally
            //{
            //    Console.WriteLine("Block finally");
            //}
        }
    }
}
