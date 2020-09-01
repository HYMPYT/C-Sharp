using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataManager dm = new DataManager();

            //dm.InitData();
            //dm.SaveData();

            dm.LoadData();
            string name;
            int choice, age, pos1, pos2;
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("1. Добавить факультет (1)");
                Console.WriteLine("2. Удалить факультет (2)");
                Console.WriteLine("3. Добавить группу (3)");
                Console.WriteLine("4. Удалить группу (4)");
                Console.WriteLine("5. Добавить студента (5)");
                Console.WriteLine("6. Удалить студента (6)");
                Console.WriteLine("7. Вывод на экран (7)");
                Console.WriteLine("8. Выйти из программы (8)");
                Console.Write(">>>>> ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\nВведите данные нового факультета");
                    Console.Write("\tНазвание: ");
                    name = Console.ReadLine();
                    Faculty faculty = new Faculty { Name = name };
                    dm.Data.AddFaculty(faculty);
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nВведите название факультета");
                    Console.Write("\tНазвание: ");
                    name = Console.ReadLine();
                    dm.Data.DelFaculty(name);
                }
                else if (choice == 3)
                {
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("\nВведите название факультета в который хотите добавить группу");
                        Console.Write("\tНазвание: ");
                        name = Console.ReadLine();
                        pos1 = dm.Data.FindFaculty(name);
                        if (pos1 == -1)
                        {
                            Console.Clear();
                            Console.WriteLine("Факультета с таким именем не существует. Повторите ввод");
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\nВведите название группы");
                    Console.Write("\tНазвание: ");
                    name = Console.ReadLine();
                    Group group = new Group { Name = name };
                    dm.Data.Faculties[pos1].AddGroup(group);
                }
                else if (choice == 4)
                {
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("\nВведите название факультета с которого хотите удалить группу");
                        Console.Write("\tНазвание: ");
                        name = Console.ReadLine();
                        pos1 = dm.Data.FindFaculty(name);
                        if (pos1 == -1)
                        {
                            Console.Clear();
                            Console.WriteLine("Факультета с таким именем не существует. Повторите ввод");
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\nВведите название группы");
                    Console.Write("\tНазвание: ");
                    name = Console.ReadLine();
                    dm.Data.Faculties[pos1].DelGroup(name);
                }
                else if (choice == 5)
                {
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("\nВведите название факультета в который хотите добавить студента");
                        Console.Write("\tНазвание: ");
                        name = Console.ReadLine();
                        pos1 = dm.Data.FindFaculty(name);
                        if (pos1 == -1)
                        {
                            Console.Clear();
                            Console.WriteLine("Факультета с таким именем не существует. Повторите ввод");
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("\nВведите название группы в которую хотите добавить студента");
                        Console.Write("\tНазвание: ");
                        name = Console.ReadLine();
                        pos2 = dm.Data.Faculties[pos1].FindGroup(name);
                        if (pos2 == -1)
                        {
                            Console.Clear();
                            Console.WriteLine("Группы с таким именем не существует. Повторите ввод");
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\nВведите данные нового студента");
                    Console.Write("\tИмя: ");
                    name = Console.ReadLine();
                    Console.Write("\tВозраст: ");
                    age = int.Parse(Console.ReadLine());
                    Student st = new Student { Name = name, Age = age };
                    dm.Data.Faculties[pos1].Groups[pos2].AddStudent(st);
                }
                else if (choice == 6)
                {
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("\nВведите название факультета с которого хотите удалить студента");
                        Console.Write("\tНазвание: ");
                        name = Console.ReadLine();
                        pos1 = dm.Data.FindFaculty(name);
                        if (pos1 == -1)
                        {
                            Console.Clear();
                            Console.WriteLine("Факультета с таким именем не существует. Повторите ввод");
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("\nВведите название группы с которой хотите удалить студента");
                        Console.Write("\tНазвание: ");
                        name = Console.ReadLine();
                        pos2 = dm.Data.Faculties[pos1].FindGroup(name);
                        if (pos2 == -1)
                        {
                            Console.Clear();
                            Console.WriteLine("Группы с таким именем не существует. Повторите ввод");
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\nВведите имя студента");
                    Console.Write("\tИмя: ");
                    name = Console.ReadLine();
                    dm.Data.Faculties[pos1].Groups[pos2].DelStudent(name);
                }
                else if (choice == 7)
                {
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("1. Вывести список факультетов (1)");
                        Console.WriteLine("2. Вывести список групп на выбраном факультете (2)");
                        Console.WriteLine("3. Вывести список студентов выбраной группы (3)");
                        Console.WriteLine("4. Вернуться в предыдущее меню (4)");
                        Console.Write(">>>>> ");
                        choice = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (choice == 1)
                        {
                            Console.Clear();
                            dm.Data.Display();
                            Console.ReadLine();
                        }
                        else if (choice == 2)
                        {
                            for (; ; )
                            {
                                Console.Clear();
                                Console.WriteLine("\nВведите название факультета");
                                Console.Write("\tНазвание: ");
                                name = Console.ReadLine();
                                pos1 = dm.Data.FindFaculty(name);
                                if (pos1 == -1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Факультета с таким именем не существует. Повторите ввод");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.Clear();
                            dm.Data.Faculties[pos1].Display();
                            Console.ReadLine();
                        }
                        else if (choice == 3)
                        {
                            for (; ; )
                            {
                                Console.Clear();
                                Console.WriteLine("\nВведите название факультета");
                                Console.Write("\tНазвание: ");
                                name = Console.ReadLine();
                                pos1 = dm.Data.FindFaculty(name);
                                if (pos1 == -1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Факультета с таким именем не существует. Повторите ввод");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            for (; ; )
                            {
                                Console.Clear();
                                Console.WriteLine("\nВведите название группы");
                                Console.Write("\tНазвание: ");
                                name = Console.ReadLine();
                                pos2 = dm.Data.Faculties[pos1].FindGroup(name);
                                if (pos2 == -1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Группы с таким именем не существует. Повторите ввод");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.Clear();
                            dm.Data.Faculties[pos1].Groups[pos2].Display();
                            Console.ReadLine();
                        }
                        else if (choice == 4)
                        {
                            break;
                        }
                    }
                }
                else if (choice == 8)
                {
                    dm.SaveData();
                    break;
                }
            }
        }
    }
}