using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"..\..\input.txt";
            string path2 = @"..\..\output.txt";
            string data;
            using (FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    data = sr.ReadToEnd();
                }
            }
            string[] content = data.Split('\n');
            double[] mas = new double[content.Length];
            for (int i = 0; i < content.Length; i++)
            {
                mas[i] = double.Parse(content[i]);
            }
            //foreach(var item in mas)
            //{
            //    Console.WriteLine(item);
            //}
            double avg = mas.Average();
            double[] err = new double[mas.Length];
            for(int i= 0; i< mas.Length; i++)
            {
                err[i] = Math.Abs(mas[i] - avg);
            }
            double avg_err = err.Average();
            using (FileStream fs = new FileStream(path2, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach(var item in mas)
                    {
                        sw.Write($"{item} ");
                    }
                    sw.WriteLine();
                    sw.WriteLine($"Середнє значення -> {avg}");
                    sw.WriteLine($"Середнє значення похибки -> {avg_err}");
                }
            }
            using (FileStream fs = new FileStream(path2, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var item in mas)
                    {
                        sw.Write($"{item} ");
                    }
                    sw.WriteLine();
                    sw.WriteLine($"Середнє значення -> {avg}");
                    sw.WriteLine($"Середнє значення похибки -> {avg_err}");
                }
            }
        }
    }
}
