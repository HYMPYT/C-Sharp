using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерфейсы
{
    public interface INndexer
    {
        int this[int index] { get; set; }
    }
    public interface IPerson
    {
        string Name { get; set; }
    }
    public interface IWork
    {
        void Work();
    }
    public interface ISing
    {
        void Sing();
    }
    public interface ISingingWorker : ISing, IWork, IPerson
    {

    }
    class Worker : IWork, IPerson
    {
        public string Name { get; set; }
        public virtual void Work()
        {
            Console.WriteLine($"{Name} does something for living");
        }
    }
    class Digger : Worker, ISingingWorker
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} is digging for living (from Worker)");
        }
        void IWork.Work()
        {
            Console.WriteLine($"{Name} is digging for living (from IWork)");
        }
        public void Sing()
        {
            Console.WriteLine($"{Name} is singing for fun");
        }
    }
    class Singer : ISing, IPerson
    {
        public string Name { get; set; }

        public void Sing()
        {
            Console.WriteLine($"{Name} is singing for living");
        }
    }
    class Artist : Worker, ISingingWorker
    {
        public void Sing()
        {
            Console.WriteLine($"{Name} is singing for employer");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            ISing[] chorus = new ISing[10];
            for (int i = 0; i < chorus.Length; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        chorus[i] = new Artist { Name = "Artist_" + i };
                        break;
                    case 1:
                        chorus[i] = new Singer { Name = "Singer_" + i };
                        break;
                    case 2:
                        chorus[i] = new Digger { Name = "Digger_" + i };
                        break;
                }
            }
            foreach (var item in chorus)
            {
                item.Sing();
            }

            //Digger a = new Digger { Name = "Digger" };
            //Worker b = new Digger { Name = "Worker" };
            //IWork c = new Digger { Name = "Iwork" };
            //a.Work();
            //b.Work();
            //c.Work();
            //ISing d = new Singer { Name = "Singer" };
            //ISing e = new Digger { Name = "Digger" };
            //d.Sing();
            //e.Sing();

            //Worker a = new Worker { Name = "Worker" };
            //IWork b = new Worker { Name = "IWork" };
            //Console.WriteLine(a.Name);
            //Console.WriteLine(((Worker)b).Name);
            //b.Work();
            //IWork c = new Digger { Name = "Digger"};
            //c.Work();
        }
    }
}
