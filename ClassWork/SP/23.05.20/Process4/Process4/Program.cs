using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Process4
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load(AssemblyName.GetAssemblyName("ClassLibrary1.dll"));
            Module mod = asm.GetModule("ClassLibrary1.dll");
            var types = mod.GetTypes();

            int count = 0;
            foreach (var t in types)
            {
                Console.WriteLine($"{++count}. {t.FullName}");
            }

            Type Person = mod.GetType("ClassLibrary1.Person") as Type;
            object person = Activator.CreateInstance(Person, new object[] { "Василий", "Пупкин", 21 });
            Person.GetMethod("Display").Invoke(person, null);

            //Console.WriteLine("+++++++++++++++++++++++++++++++++");
            //Type Employee = mod.GetType("ClassLibrary1.Employee") as Type;
            //object employee = Activator.CreateInstance(Person, new object[] { "Андрей", "Андреев", 27, "Программист", 1900 });
            //Employee.GetMethod("Display").Invoke(employee, null);

        }
    }
}
