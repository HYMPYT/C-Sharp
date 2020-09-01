using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делегаты
{
    public delegate void Greeting();
    public delegate double Calc(double a, double b);
    class MyCalc
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public double Dif(double a, double b)
        {
            return a - b;
        }
        public double Prod(double a, double b)
        {
            return a * b;
        }
    }
    class Test
    {
        public void Hi()
        {
            Console.WriteLine("Hi");
        }
        private void Hola()
        {
            Console.WriteLine("Hola");
        }
        public void SetDlg(out Greeting obj)
        {
            obj = Hola;
        }
    }
    class Program
    {
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }
        public static int Compare(int a, int b)
        {
            return b - a;
        }
        public static string ConvertToString(int value)
        {
            return value.ToString();
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                list.Add(rnd.Next(100, 2000));
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            //list.Sort(Compare);
            //list.Sort(delegate (int a, int b) { return a - b; });
            list.Sort((a, b) => a - b);
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //var list_str = list.ConvertAll(ConvertToString);
            //var list_str = list.ConvertAll(delegate (int value) { return value.ToString(); });
            var list_str = list.ConvertAll(value => value.ToString());
            foreach (var item in list_str)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(list_str[0] + list_str[1]);

            //Calc calc = MyCalc.Sum;
            //MyCalc obj = new MyCalc();
            //calc += obj.Dif;
            //calc += obj.Prod;
            //calc += obj.Dif;
            //calc += obj.Prod;
            ////Console.WriteLine(calc(12, 3)); 
            //foreach(Calc item in calc.GetInvocationList())
            //{
            //    Console.WriteLine(item(12, 3));
            //}

            //Greeting a = Hello;
            //Test obj = new Test();
            //Greeting b = obj.Hi;
            ////a();
            ////b();
            //Greeting c;
            //obj.SetDlg(out c);
            ////c();
            //a += b;
            //a += b;
            //a += b;
            //a -= b;
            //a += c;
            //a();
        }
    }
}
