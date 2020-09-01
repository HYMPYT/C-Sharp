using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"..\..\input_1.txt";
            string path2 = @"..\..\input_2.txt";
            string path3 = @"..\..\output.txt";
            string content;

            // зчитування данних із файла 1

            using (FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                }
            }

            // формування масиву прізвищ з файлу 1

            string[] name_1 = content.Split('\n');
            Array.Resize(ref name_1, name_1.Length - 1);

            // зчитування данних із файла 2

            using (FileStream fs = new FileStream(path2, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                }
            }

            // формування масиву прізвищ з файлу 2

            string[] name_2 = content.Split('\n');
            Array.Resize(ref name_2, name_2.Length - 1);

            // формування масиву прізвищ шляхом об'єднання першого і другого масивів

            string[] final = new string[name_1.Length + name_2.Length];
            for (int i = 0; i < name_1.Length; i++)
            {
                final[i] = name_1[i];
            }
            for (int i = name_1.Length, j = 0; j < name_2.Length; i++, j++)
            {
                final[i] = name_2[j];
            }

            // сортування масиву

            Array.Sort(final);

            // запис відсортованого масиву у файл

            using (FileStream fs = new FileStream(path3, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for(int i = 0; i < final.Length; i++)
                    {
                        sw.Write($"{i + 1}. {final[i]}");
                    }
                }
            }

            // # - finish
            Console.WriteLine("Программа завершена");
        }
    }
}
