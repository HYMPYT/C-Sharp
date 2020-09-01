using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_generic
{
    class Program
    {
        class MyCollection : IEnumerator
        {
            private List<int> _list;
            Random rnd = new Random();

            public object Current => throw new NotImplementedException();

            public MyCollection()
            {
                _list = new List<int>();
                for (int i = 0; i < 25; i++)
                {
                    _list.Add(rnd.Next(12, 456));
                }
            }
            public void Print()
            {
                foreach(var item in _list)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
            public IEnumerator GetEnumerator()
            {
                for(int i = 0; i<_list.Count; i++)
                {
                    if (i == 10)
                        yield break;
                    yield return _list[i];
                }
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            MyCollection list = new MyCollection();
            list.Print();
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //List<int> list = new List<int>();

            //LinkedList<int> linked = new LinkedList<int>();

            //Stack<int> stk = new Stack<int>();

            //Queue<int> queue = new Queue<int>();

            //SortedList<int, string> sorted = new SortedList<int, string>();
            //sorted.Add(1, "one");
            //sorted.Add(5, "five");
            //sorted.Add(3, "three");
            //sorted.Add(2, "two");
            //sorted.Add(4, "four");

            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "one");
            //dict.Add(5, "five");
            //dict.Add(3, "three");
            //dict.Add(2, "two");
            //dict.Add(4, "four");
            //foreach (var key in dict.Keys)
            //{
            //    Console.WriteLine($"{key} -> {dict[key]}");
            //}
        }
    }
}
