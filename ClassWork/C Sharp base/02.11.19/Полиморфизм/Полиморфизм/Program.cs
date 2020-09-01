using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyClass
{

}
namespace Полиморфизм
{
    class MyClass
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            global::MyClass a = new global::MyClass();

            //Person a = new Person { Name = "Name", Birthday = DateTime.Now };
            //Person d = new Person { Name = "Ivan", Birthday = DateTime.Parse("27/4/1997") };
            //Person b = new Person { Name = "Name", Birthday = a.Birthday };
            //Person c = a;
            ////if(a.Equals(b))
            ////{
            ////    Console.WriteLine("++++++++");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("--------");
            ////}
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
            //Console.WriteLine(c.GetHashCode());
            //Console.WriteLine(d.GetHashCode());

            //Random rnd = new Random();
            //Employee[] company = new Employee[5];
            //for (int i = 0; i < company.Length; i++)
            //{
            //    switch (rnd.Next(3))
            //    {
            //        case 0:
            //            company[i] = new Manager("Manager_" + i, new DateTime(rnd.Next(1970, 2000), rnd.Next(12) + 1, rnd.Next(28) + 1), "Company_" + i, new DateTime(rnd.Next(2003, 2019), rnd.Next(12) + 1, rnd.Next(28) + 1));
            //            break;
            //        case 1:
            //            company[i] = new Worker("Worker_" + i, new DateTime(rnd.Next(1970, 2000), rnd.Next(12) + 1, rnd.Next(28) + 1), "Company_" + i, new DateTime(rnd.Next(2003, 2019), rnd.Next(12) + 1, rnd.Next(28) + 1));
            //            break;
            //        case 2:
            //            company[i] = new Digger("Digger_" + i, new DateTime(rnd.Next(1970, 2000), rnd.Next(12) + 1, rnd.Next(28) + 1), "Company_" + i, new DateTime(rnd.Next(2003, 2019), rnd.Next(12) + 1, rnd.Next(28) + 1));
            //            break;
            //    }
            //}
            ////foreach (var item in company)
            ////{
            ////    Console.WriteLine(item);
            ////    item.DoWork();
            ////    Console.WriteLine();
            ////    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ////}

            //foreach (var item in company)
            //{
            //    //try
            //    //{
            //    //    ((Manager)item).LookingToTheWindow();
            //    //}
            //    //catch (Exception e)
            //    //{
            //    //    Console.WriteLine(e.Message);
            //    //}

            //    (item as Manager)?.LookingToTheWindow();
            //    (item as Worker)?.ExtraWork();

            //    //if(item is Manager tmp)
            //    //{
            //    //    tmp.LookingToTheWindow();
            //    //}
            //}

            ////Employee a = new Employee("Ivan", DateTime.Parse("3/5/2000"), "SomeCompany", DateTime.Now, 300);
            ////Console.WriteLine(a);
        }
    }
}
