using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generic.Test;
using static System.Math;

namespace Generic
{
    static class Test
    {
        public static T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
    class Point<T> where T : struct
    {
        private T _x;
        private T _y;
        public Point(T x, T y)
        {
            _x = x;
            _y = y;
        }
        public Point()
        {
            _x = default(T);
            _y = default(T);
        }
        public T X
        {
            get => _x;
            set => _x = value;
        }
        public T Y
        {
            get => _y;
            set => _y = value;
        }
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        public override string ToString()
        {
            return $"X = {X}\n" +
                $"Y = {Y}\n";
        }
    }

    class Point3D<T> : Point<T> where T : struct
    {
        T _z;
        public Point3D(T x, T y, T z) : base(x, y)
        {
            _z = z;
        }
        public T Z
        {
            get => _z;
            set => _z = value;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Z = {Z}\n";
        }
    }

    //class Point3D : Point<int>
    //{
    //    int _z;
    //    public int Z
    //    {
    //        get => _z;
    //        set => _z = value;
    //    }
    //    public Point3D(int x, int y, int z) : base(x, y)
    //    {
    //        _z = z;
    //    }
    //    public override string ToString()
    //    {
    //        return $"{base.ToString()}" +
    //            $"Z = {Z}\n";
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Point3D<int> a = new Point3D<int>(1, 2, 3);
            //Console.WriteLine(a);

            //Console.WriteLine(Max(12, 23));
            //Console.WriteLine(Pow(12, 2));


            Point<int>.PrintHello();
            Point<int> a = new Point<int>(1, 2);
            Point<double> b = new Point<double>(1.3, 2.6);
            //Point<string> c = new Point<string>("1.3", "2.6");
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine(c);
        }
    }
}
