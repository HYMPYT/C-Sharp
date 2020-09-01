using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static object Find(object[]arr, Predicate<object> predicate)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (predicate(arr[i]))
                {
                    return arr[i];
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            object[] arr = new object[10];
            int elem;
            object rez;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            Console.Write("Введите элемент для поиска -> ");
            elem = int.Parse(Console.ReadLine());
            rez = Find(arr, x => (int)x == elem);
            if(rez!=null)
            {
                Console.WriteLine($"Элемент -> {rez}");
            }
            else
            {
                Console.WriteLine("Такого элемента нету");
            }
        }
    }
}
