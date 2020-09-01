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
            Console.WriteLine("---------------");
            Console.WriteLine("| Калькулятор |");
            Console.WriteLine("---------------");
            Console.ReadLine();
            Calculator c = new Calculator();
            int op;
            double num1, num2;
            for (; ; )
            {

                Console.Clear();
                Console.Write("Введите первое число -> ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число -> ");
                num2 = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|     Выберите операцию     |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"| 1. {num1,-10} + {num2,10}|");
                Console.WriteLine($"| 2. {num1,-10} - {num2,10}|");
                Console.WriteLine($"| 3. {num1,-10} * {num2,10}|");
                Console.WriteLine($"| 4. {num1,-10} / {num2,10}|");
                Console.WriteLine($"| 5. {num1,-10} % {num2,10}|");
                Console.WriteLine("| 6. Закончить работу       |");
                Console.WriteLine("-----------------------------");
                Console.Write(">>> ");
                op = int.Parse(Console.ReadLine());
                if (op > 0 && op < 7)
                {
                    if (op == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Программа завершена");
                        break;
                    }
                    if(op == 4 && (c[op - 1].Invoke(num1, num2)) == 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine($"Результат => {c[op - 1].Invoke(num1, num2)}");
                    Console.ReadLine();
                }
            }
        }
    }
}
