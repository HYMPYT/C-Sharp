using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace колекции
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("one", "один");
            ht.Add("два", 2);
            ht.Add(3, "three");
            foreach (var key in ht.Keys)
            {
                Console.WriteLine($"{key} -> {ht[key]}");
            }



            //SortedList
            //SortedList sl = new SortedList();
            //sl.Add("one", 1);
            //sl.Add("two", 2);
            //sl.Add("three", 3);
            //sl.Add("four", 4);
            //sl.Add("five", 5);
            //foreach (var key in sl.Keys)
            //{
            //    Console.WriteLine($"{key} -> {sl[key]}");
            //}


            //Queue
            //Queue queue = new Queue();
            //for (int i = 0; i < 15; i++)
            //{
            //    queue.Enqueue(i + 1);
            //}
            //while (queue.Count != 0)
            //{
            //    Console.Write($"{queue.Dequeue()}  ");
            //}
            //Console.WriteLine();


            //Stack
            //Stack stk = new Stack();
            //stk.


            //ArrayList
            //var list = new ArrayList();
            ////list.Add(122);
            ////list.Add("122");
            ////list.Add('1');
            ////list.Add(23.45);
            ////list.Add(23);
            ////Console.WriteLine(list.Count);
            ////Console.WriteLine(list.Capacity);
            ////foreach(var item in list)
            ////{
            ////    Console.Write($"{item}   ");
            ////}
            ////Console.WriteLine();
            ////list.Insert(3, "Hello");
            ////foreach (var item in list)
            ////{
            ////    Console.Write($"{item}   ");
            ////}
            ////Console.WriteLine();
            ////list.Remove('1');

            //list.Add(1);
            //list.Add(3);
            //list.Add(7);
            //list.Add(5);
            //list.Add(5);
            //list.Add(5);
            //list.Add(8);
            //list.Sort();
            //foreach (var item in list)
            //{
            //    Console.Write($"{item}   ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(list.BinarySearch(5));
            //Console.WriteLine(list.IndexOf(5));
        }
    }
}
