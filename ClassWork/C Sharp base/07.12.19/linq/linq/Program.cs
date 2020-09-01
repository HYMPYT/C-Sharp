using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public static class ExtMethods
    {
        public static int WordCounter(this string str)
        {
            return str.Split(" .,!?;:-/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "aeef ewfwefw wefwrhe rt ewevew rtymyt wvwev ehet";
            //Console.WriteLine(str.WordCounter());
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                list.Add(rnd.Next(100, 2000));
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            var result = list.Select(x => x.ToString()).Aggregate((x, y) => x + y).Select(x => int.Parse(x.ToString()));
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            ////var result = (from x in list
            ////              where x % 2 == 0
            ////              select x).ToList();
            //var result = from x in list
            //             let tmp = list.Average()
            //             where x > tmp
            //             select x;
            ////var result = list.Where(x => x % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(result.Aggregate((x, y) => x + y));


            //var str_res = list.Select(x =>
            //{
            //    if (x % 2 != 0)
            //        return x + 1;
            //    return x;
            //});
            //foreach (var item in str_res)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //list.RemoveRange(10, 15);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
        }
    }
}
//Map Filter Reduce