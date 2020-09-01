using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    public class Person
    {
        string _name;
        readonly DateTime _birthday;
        static int _counter;
        public const string Planet = "Earth";

        //public string GetName()
        //{
        //    return _name;
        //}
        //public void SetName(string name) => _name = name;

        
        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string LastName { get; set; }//автосвойство prop || propfull
        public static int Counter => _counter;
        public DateTime Birthday => _birthday;
        public static void TestMethod()
        {
            Console.WriteLine(Counter);
            Console.WriteLine(Planet);
        }
        public Person(string name, DateTime birthday)
        {
            _name = name;
            _birthday = birthday;
            _counter++;
        }
        public Person() : this("Noname", DateTime.Now)
        { }
        static Person()
        {
            Console.WriteLine("Static Constructor");
            _counter = 0;
        }
        public override string ToString()
        {
            return $"Name: {_name}\n" +
                $"LastName: {LastName}\n" +
                $"Birthday: {_birthday.ToLongDateString()}\n" +
                $"Planet: {Planet}\n" +
                $"Number of peple: {_counter}\n";
        }
    }
}