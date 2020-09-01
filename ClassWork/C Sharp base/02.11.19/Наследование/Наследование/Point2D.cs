using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point2D(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X = {X}" +
                $" Y = {Y}\n";
        }
        public virtual void Move(int distance)
        {
            X += distance;
            Y += distance;
        }
    }
}
