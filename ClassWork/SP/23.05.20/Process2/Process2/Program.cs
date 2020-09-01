using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Process2
{
    class Program
    {
        static void Main(string[] args)
        {
            string exeFile = "notepad.exe";
            Console.WriteLine("Запущено консольное приложение");
            Console.WriteLine($"Ассоциированый процесс: {Process.GetCurrentProcess().ProcessName}");

            Process process = new Process();
            process.StartInfo.FileName = exeFile;
            process.Start();

            Console.WriteLine($"\nЗапущен внешний процесс {process.ProcessName}");
            Console.WriteLine($"Ожыдание завершения внешнего процесса ...");
            process.WaitForExit();

            Console.WriteLine($"\nВнешний процесс завершен с кодом {process.ExitCode}");
            Console.WriteLine("\nПрограмма завершена");
            process.Close();
        }
    }
}
