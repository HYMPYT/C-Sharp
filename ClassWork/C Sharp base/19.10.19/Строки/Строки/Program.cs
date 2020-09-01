using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder sb = new StringBuilder("");
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                if (i < 5 || i >= 10)
                    sb.Append(rnd.Next(10));
                else
                    sb.Append((Char)rnd.Next(65, 93));
            }
            Console.WriteLine("ID -> " + sb.ToString());


            //StringBuilder sb = new StringBuilder("Hello");
            //sb[0] = 'h';
            //for (int i = 0; i < sb.Length; i++)
            //{
            //    Console.Write(sb[i] + " ");
            //}
            //Console.WriteLine();


            //string str = String.Empty;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.Write(str[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Hello".Insert(5, "!"));
            //Console.WriteLine("Hello".Remove(2, 3));
            //Console.WriteLine("Hello".Replace("l", "L"));
            //string[] arr = "one,, two /, three .: four , five".Split(", .:;/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Hello".Substring(1, 3));
            //Console.WriteLine("..!..Hello.......".Trim('.'));
            //Console.WriteLine("Hello".CompareTo("Hello"));
            //Console.WriteLine("Hello!".EndsWith("!"));
            //Console.WriteLine("Hello!".IndexOf("!"));
            //Console.WriteLine("Hello!".PadLeft(10, '!'));
            //str = string.Join(",", arr);
            //Console.WriteLine(str);
            //Console.WriteLine(string.CompareOrdinal("Z", "A"));
            //Console.WriteLine(string.IsNullOrWhiteSpace("    l "));
            //Console.WriteLine(string.Format("Today is {0} {1} {2}!", 19, "October", 2019));
            //Console.WriteLine($"Today is {19} {"October"} {2019}!");

            //double a = 2.5;
            //Console.WriteLine($"{a}");

            //string path = @"D:\yevhen\";
            //Console.WriteLine(path);


        }
    }
}