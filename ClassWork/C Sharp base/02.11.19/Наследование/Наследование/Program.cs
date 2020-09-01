using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D a = new Point2D(12, 23);
            Point2D b = new Point3D(1, 2, 3);
            a.Move(5);
            Console.WriteLine(a);
            b.Move(5);
            Console.WriteLine(b);
            //Point3D a = new Point3D(1, 2, 3);
            //Console.WriteLine(a);
        }
    }
}
