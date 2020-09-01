using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Process3
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] arr = Process.GetProcesses();
            foreach (Process p in arr)
            {
                Console.WriteLine($"{p.Id,-10} - {p.ProcessName}");
            }
        }
    }
}
