using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка_операторов
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 3);
            Console.WriteLine(b);
            double tmp = (double)b;
            Console.WriteLine(tmp);
            b = (Fraction)tmp;
            Console.WriteLine(b);
            Console.WriteLine(a);


            //int a, b;
            //a = Int32.Parse(Console.ReadLine());
            //b = Int32.Parse(Console.ReadLine());


            //var a = new Fraction(1, 2);
            //var b = new Fraction(1, 3);
            //if (a && b)
            //    Console.WriteLine("++++++");
            //else
            //    Console.WriteLine("------");

            ///*Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a <= b);*/

            //if (a)
            //    Console.WriteLine("++++++++");
            //else
            //    Console.WriteLine("--------");

            //if(a == b)
            //    Console.WriteLine("++++++++++");
            //else
            //    Console.WriteLine("----------");

            //Console.WriteLine(a);
            //a++;
            //Console.WriteLine(a);
            //++a;
            //Console.WriteLine(!a);

            //var b = new Fraction(1, 3);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //var c = a + 2;
            //Console.WriteLine(c);
        }
    }
}
