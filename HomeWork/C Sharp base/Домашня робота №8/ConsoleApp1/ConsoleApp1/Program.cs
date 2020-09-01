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
            LinkedList<int> list = new LinkedList<int>();
            list.AddTail(1);
            list.AddTail(2);
            list.AddTail(3);
            Console.Write("Add tail: ");
            list.Print();
            list.AddInPosition(4, 2);
            Console.Write("Add in position: ");
            list.Print();
            LinkedList<int> list_2 = new LinkedList<int>();
            list_2.AddTail(5);
            list_2.AddTail(6);
            list_2.AddTail(7);
            Console.Write("Add range in position: ");
            list.AddRangeInPosition(ref list_2, 4);
            list.Print();
            Console.Write("Remove: ");
            list.RemoveHead();
            list.Print();
            Console.Write("Remove in position: ");
            list.RemoveInPosition(4);
            list.Print();
            Console.Write("Remove range in position: ");
            list.RemoveRangeInPositiion(2, 2);
            list.Print();
        }
    }
}
