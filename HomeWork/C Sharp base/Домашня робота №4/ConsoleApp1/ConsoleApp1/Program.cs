using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Transport[] transport = new Transport[7];
            for(int i = 0; i<transport.Length; i++)
            {
                switch(rnd.Next(7))
                {
                    case 0:
                        transport[i] = new Automobile("Mersedes", 1600, 2.2, rnd.Next(10000));
                        break;
                    case 1:
                        transport[i] = new PassengerAuto("Nissan", 1800, 1.6, rnd.Next(10000), 6);
                        break;
                    case 2:
                        transport[i] = new Truck("KAMAZ", 3000, 1.8, rnd.Next(10000), 10.5);
                        break;
                    case 3:
                        transport[i] = new Train("Passenger", rnd.Next(1000), rnd.Next(10000));
                        break;
                    case 4:
                        transport[i] = new Plane("Military", "Reactive", rnd.Next(10000));
                        break;
                    case 5:
                        transport[i] = new PassengerPlane("Helical", rnd.Next(10000), 720);
                        break;
                    case 6:
                        transport[i] = new CargoAirplane("Reactive", rnd.Next(10000), 150);
                        break;
                }
            }
            foreach (var item in transport)
            {
                Console.WriteLine(item.Info());
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
    }
}
