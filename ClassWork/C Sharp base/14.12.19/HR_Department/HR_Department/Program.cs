using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Department
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            DataManager dm = new DataManager();
            //dm.InitData();
            //dm.SaveData();

            dm.LoadData();
            Console.WriteLine("Ok");

            dm.Data.Display();
            dm.Data.Departments[0].Display();

            //Console.WriteLine("\nВведите данные нового сотрудника");
            //Console.Write("  Имя: ");
            //string name = Console.ReadLine();
            //Console.Write("  Возраст: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("  Должность: ");
            //string position = Console.ReadLine();
            //Console.Write("  Зарплата: ");
            //decimal salary = decimal.Parse(Console.ReadLine());

            //Employe emp = new Employe { Name = name, Age = age, Position = position, Salary = salary };
            //dm.Data.Departments[0].AddEmploye(emp);

            //dm.SaveData();
            //Console.WriteLine("Сотрудник успешно добавлен");

            Console.WriteLine();
            var res = dm.Data.Departments[0].Employes
                .Where(e => e.Age > 21).ToList();
            int i = 0;
            foreach (var x in res)
            {
                i++;
                Console.WriteLine($"{i}. {x}");
            }

        }
    }
}
