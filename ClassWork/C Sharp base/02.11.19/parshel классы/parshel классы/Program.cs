using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parshel_классы
{
    partial class Rectangle
    {
        public override string ToString()
        {
            return $"Height: {_height}\n" +
                $"Widht: {_width}\n";
        }
        public int Square => Width * Height;
        public int Perimeter => (Width + Height) * 2;
    }
    partial class Rectangle
    {
        int _height;
        int _width;
        public int Height { get => _height; set => _height = value; }
        public int Width { get => _width; set => _width = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle { Height = 4, Width = 6};
            Console.WriteLine(a.ToString());
            Console.WriteLine("Square -> " + a.Square);
            Console.WriteLine("Perimeter -> " + a.Perimeter);
        }
    }
}
