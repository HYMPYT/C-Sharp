using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyCh
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl1 = new Client("Anton");
            Console.WriteLine(cl1);
            cl1.Name = "Pavel";
            Console.WriteLine(cl1);
            LibraryCard lb = new LibraryCard("card", cl1);

            Console.WriteLine();
            Console.WriteLine(lb);
            lb.Client = new Client("Vasya");

            Console.WriteLine();
            Console.WriteLine(lb);
        }
    }
}
