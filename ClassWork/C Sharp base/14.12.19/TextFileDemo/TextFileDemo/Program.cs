using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"..\..\TextFile.txt";
            string path2 = @"..\..\output.txt";
            //1 - Зчитування данних із файла
            string content;
            using (FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                }
            }
            Console.WriteLine(content);
            Console.WriteLine();

            //2 - Створення масиву прізвищ
            string[] names = content.Split('\n');
            Console.WriteLine(names[0]);
            Console.WriteLine();
            Array.Resize(ref names, names.Length - 1);


            //3 - Сортіровка
            Array.Sort(names);
            int k = 0;
            foreach (string item in names)
            {
                k++;
                Console.WriteLine($"{k}. {item}");
            }
            Console.WriteLine();

            // 4 - Запис відсортованого списка у файл
            using (FileStream fs = new FileStream(path2, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    int n = 0;
                    foreach (string item in names)
                    {
                        n++;
                        sw.Write($"{n}. {item}");
                    }
                }
            }

            // # - finish
            Console.WriteLine("Программа завершена");
        }
    }
}
