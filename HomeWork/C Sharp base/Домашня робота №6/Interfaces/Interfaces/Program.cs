using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Product[] products = new Product[10];
            
            for (int i = 0; i < products.Length; i++)
            {
                switch (rnd.Next(5))
                {
                    case 0:
                        if (i % 2 == 0)
                            products[i] = new Alcohol(0, "Alcohol", "Broken", DateTime.Today, new DateTime(rnd.Next(2000, 2020), rnd.Next(1, 13), rnd.Next(1, 29)));
                        else
                            products[i] = new Alcohol(0, "Alcohol", "Entire", DateTime.Today, new DateTime(rnd.Next(2000, 2020), rnd.Next(1, 13), rnd.Next(1, 29)));
                        break;
                    case 1:
                        products[i] = new MilkProducts(1, "Milk", new DateTime(2019, rnd.Next(1, 13), rnd.Next(1, 29)), new DateTime(2019, rnd.Next(1, 13), rnd.Next(1, 29)));
                        break;
                    case 2:
                        products[i] = new Fruits(2, "Fruits", new DateTime(2019, rnd.Next(1, 13), rnd.Next(1, 29)), new DateTime(2019, rnd.Next(1, 13), rnd.Next(1, 29)));
                        break;
                    case 3:
                        products[i] = new AirFreshener(3, "Air Freshener", DateTime.Today, new DateTime(rnd.Next(2017, 2020), rnd.Next(1, 13), rnd.Next(1, 29)));
                        break;
                    case 4:
                        products[i] = new GlassCleaner(4, "Glass Cleaner", DateTime.Today, new DateTime(rnd.Next(2016, 2020), rnd.Next(1, 13), rnd.Next(1, 29)));
                        break;
                }
            }
            HasArrived a = new HasArrived(10, products);
            WrittenOfGoods b = new WrittenOfGoods();
            Console.WriteLine("==================Has arrived=======================");
            a.Print();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] is Alcohol)
                    if (((Alcohol)a[i]).Check(a[i]))
                    {
                        b.Add(a[i]);
                        a.Delete(a, i);
                        i--;
                        continue;
                    }

                if (a[i] is MilkProducts)
                    if (((MilkProducts)a[i]).CheckExpiraionDate(a[i]))
                    {
                        b.Add(a[i]);
                        a.Delete(a, i);
                        i--;
                        continue;
                    }

                if (a[i] is Fruits)
                    if (((Fruits)a[i]).CheckExpiraionDate(a[i]))
                    {
                        b.Add(a[i]);
                        a.Delete(a, i);
                        i--;
                        continue;
                    }
            }
            Console.WriteLine("===============Written of goods=====================");
            b.Print();
            Implemented c = new Implemented(a);
            Console.WriteLine("==================Implemented=======================");
            c.Print();
            TransferredGoods d = new TransferredGoods(b);
            b.DeleteAll(b);
            Console.WriteLine("==================Transferred=======================");
            d.Print();
        }
    }
}