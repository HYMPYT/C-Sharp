using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class Mathematical
    {
        public static double exp(double d)
        {
            return Math.Exp(d);
        }
        public static double arcsin(double gradus)
        {
            return Math.Asin(gradus / 57.29);
        }
        public static double distanceBetweenPoints(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        }
        public static T[,] Transpose<T>(T[,] arr)
        {
            T[,] tmp = new T[arr.GetLength(1), arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    tmp[j, i] = arr[i, j];
            }
            return tmp;
        }
    }
}