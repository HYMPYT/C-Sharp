using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Coefficient
    {
        public int A, B;
    }
    static class LinearEquation
    {
        public static void Parse(string data, ref Coefficient coefficient)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new FormatException("No string");
            }

            string[] number = data.Split(", ".ToCharArray());
            if (number.Length > 2)
            {
                throw new FormatException("Too many arguments.");
            }
            else if (number.Length < 2)
            {
                throw new FormatException("Too few arguments.");
            }
            else
            {
                bool rez = int.TryParse(number[0], out coefficient.A);
                if (!rez)
                    throw new FormatException("Can't convert first number to int32.");

                rez = int.TryParse(number[1], out coefficient.B);
                if (!rez)
                    throw new FormatException("Can't convert second number to int32.");
            }
        }
        public static double[] TheSolutionOfLinearEquation(string param)
        {
            string[] tmp = param.Split(", ".ToCharArray());
            double[] first_number = new double[3], second_number = new double[3];
            
            for (int i = 0, j = 0; i < tmp.Length; i++)
            {
                if (i > 2 && i < 6)
                {
                    second_number[j] = int.Parse(tmp[i]);
                    j++;
                }
                else
                {
                    first_number[i] = int.Parse(tmp[i]);
                }
            }
            double det = first_number[0] * second_number[1] - first_number[1] * second_number[0];
            if (det == 0)
            {
                throw new ArgumentOutOfRangeException("The solution does not exist.");
            }
            else
            {
                double[] rez = new double[2];
                rez[0] = (first_number[2] * second_number[1] - first_number[1] * second_number[2]) / det;
                rez[1] = (first_number[0] * second_number[2] - first_number[2] * second_number[0]) / det;
                return rez;
            }
        }
    }
}
