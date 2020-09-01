using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Digger d = new Digger();
            ((Employee)d).DoWork();
            /*
            Random rnd = new Random();
            Employee[] company = new Employee[5];
            for (int i = 0; i < company.Length; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        company[i] = new Manager("Manager_"+i,new DateTime(rnd.Next(1970,2000),rnd.Next(12)+1,rnd.Next(28)+1),"Company_"+i, new DateTime(rnd.Next(2003,2019),rnd.Next(12)+1,rnd.Next(28)+1));
                        break;
                    case 1:
                        company[i] = new Worker("Worker_"+i,new DateTime(rnd.Next(1970,2000),rnd.Next(12)+1,rnd.Next(28)+1),"Company_"+i, new DateTime(rnd.Next(2003,2019),rnd.Next(12)+1,rnd.Next(28)+1));
                        break;
                    case 2:
                        company[i] = new Digger();
                        break;
                }   
            }

*/
            /*foreach (var item in company )
            {
                Console.WriteLine(item);
                item.DoWork();
                Console.WriteLine();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
*/

            /*foreach (var item in company )
            {
                /*try
                {
                    ((Manager) item).LookingToTheWindow();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                }#1#
                
                (item as Manager)?.LookingToTheWindow();

                
                if (item is Manager tmp)
                {
                    tmp.LookingToTheWindow();
                }
            }*/
            
        }
    }
}