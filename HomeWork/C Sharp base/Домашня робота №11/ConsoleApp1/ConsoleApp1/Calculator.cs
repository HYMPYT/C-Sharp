using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate double CalculatorDelegate(double a, double b);
    class Calculator
    {
        CalculatorDelegate[] cd;
        public CalculatorDelegate this[int index]
        {
            get => cd[index];
        }
        public Calculator()
        {
            cd = new CalculatorDelegate[]
            {
                Sum, Dif, Mul, Div, Mod
            };
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Dif(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.Clear();
                Console.WriteLine("Деление на ноль запрещено");
                Console.ReadLine();
                return 0;
            }
            return a / b;
        }
        public double Mod(double a, double b)
        {
            return a % b;
        }
    }
}
