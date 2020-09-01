using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginWindow lw = new LoginWindow();
            Application app = new Application();
            string pattern = @"^[a-z][a-zA-Z0-9_\-]{4,11}$";
            Regex regex = new Regex(pattern);
            string login, password;
            int choice;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|     Прототип приложения     |");
            Console.WriteLine("-------------------------------");
            Console.ReadLine();
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("| 1. Вход (1)                 |");
                Console.WriteLine("| 2. Зарегестрироваться (2)   |");
                Console.WriteLine("| 3. Выйти (3)                |");
                Console.WriteLine("-------------------------------");
                Console.Write(">>> ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    for (; ; )
                    {
                        Console.Clear();
                        Console.Write("Введите логин -> ");
                        login = Console.ReadLine();
                        if (!(regex.IsMatch(login)))
                        {
                            Console.Clear();
                            Console.WriteLine("Логин - не валидный!");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Логин - валидный!");
                            break;
                        }
                    }
                    Console.Write("Введите пароль -> ");
                    password = Console.ReadLine();
                    app.AppLoad(login, password);
                    Console.ReadLine();
                }
                else if (choice == 2)
                {
                    for (; ; )
                    {
                        Console.Clear();
                        Console.Write("Введите логин -> ");
                        login = Console.ReadLine();
                        if (!(regex.IsMatch(login)))
                        {
                            Console.Clear();
                            Console.WriteLine("Логин - не валидный!");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Логин - валидный!");
                            break;
                        }
                    }
                    Console.Write("Введите пароль -> ");
                    password = Console.ReadLine();
                    lw.Registration(login, password, app);
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Программа завершена");
                    break;
                }
            }
        }
    }
}
