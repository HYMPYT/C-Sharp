using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Point3D : Point2D
    {
        public int Z { get; set; }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public override void Move(int distance)
        {
            base.Move(distance);
            Z += distance;
        }
        public override string ToString()
        {
            return base.ToString().TrimEnd('\n') + $" Z = {Z}";
        }
    }
}
