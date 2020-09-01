using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Coefficient coef = new Coefficient();
            Console.Write("Введите строку с параметрами линейного уравнения. Формат (A,B/A B) -> ");
            string param = Console.ReadLine();
            try
            {
                LinearEquation.Parse(param, ref coef);
                Console.WriteLine($"{coef.A}x + {coef.B}y = 0");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            //Task 2

            //Console.Write("Введите строку с параметрами линейных уравнений. Формат (A1,B1,C1,A2,B2,C2/A1 B1 C1 A2 B2 C2) -> ");
            //string param = Console.ReadLine();
            //try
            //{
            //    double[] rez = LinearEquation.TheSolutionOfLinearEquation(param);
            //    Console.WriteLine($"X -> {Math.Round(rez[0], 3)}\nY -> {Math.Round(rez[1], 3)}");
            //}
            //catch(ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
