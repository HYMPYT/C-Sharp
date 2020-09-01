using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Перечесления
{
    enum Gender
    {
        Male = 29,
        Female = 356,
        Unknown = 394
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.Male;
            foreach(int key in Enum.GetValues(typeof(Keys)))
            {
                Console.WriteLine($"{key} -> {Enum.GetName(typeof(Keys), key)}");
            }


            //Console.WriteLine(gender);
            //string[] names = Enum.GetNames(typeof(Gender));
            //foreach (var item in names)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //int[] values = (int[])Enum.GetValues(typeof(Gender));
            //foreach (var value in values)
            //{
            //    Console.Write(value + " ");
            //}
            //Console.WriteLine();

        }
    }
}