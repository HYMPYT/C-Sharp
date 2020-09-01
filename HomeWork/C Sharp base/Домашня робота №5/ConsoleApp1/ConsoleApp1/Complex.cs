using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Complex
    {
        public double Really { get; set; }
        public double Imaginary { get; set; }
        public Complex(double really, double imaginary)
        {
            Really = really;
            Imaginary = imaginary;
        }
        public static Complex operator +(Complex l, Complex r)
        {
            return new Complex(l.Really + r.Really, l.Imaginary + r.Imaginary);
        }
        public static Complex operator +(int l, Complex r)
        {
            return new Complex(l + r.Really, r.Imaginary);
        }
        public static Complex operator +(Complex l, int r)
        {
            return new Complex(l.Really + r, l.Imaginary);
        }
        public static Complex operator -(Complex l, Complex r)
        {
            return new Complex(l.Really - r.Really, l.Imaginary - r.Imaginary);
        }
        public static Complex operator -(Complex l, int r)
        {
            return new Complex(l.Really - r, l.Imaginary);
        }
        public static Complex operator -(int l, Complex r)
        {
            return new Complex(l - r.Really, 0 - r.Imaginary);
        }
        public static Complex operator *(Complex l, Complex r)
        {
            return new Complex(l.Really * r.Really - l.Imaginary * r.Imaginary, l.Imaginary * r.Really + l.Really * r.Imaginary);
        }
        public static Complex operator *(int l, Complex r)
        {
            return new Complex(l * r.Really, l * r.Imaginary);
        }
        public static Complex operator *(Complex l, int r)
        {
            return new Complex(l.Really * r, l.Imaginary * r);
        }
        public static Complex operator /(Complex l, Complex r)
        {
            double really = (l.Really * r.Really + l.Imaginary * r.Imaginary) / (Math.Pow(r.Really, 2) + Math.Pow(r.Imaginary, 2));
            double imaginary = (l.Imaginary * r.Really - l.Really * r.Imaginary) / (Math.Pow(r.Really, 2) + Math.Pow(r.Imaginary, 2));
            return new Complex(really, imaginary);
        }
        public static Complex operator /(int l, Complex r)
        {
            double really = (l * r.Really) / (Math.Pow(r.Really, 2) + Math.Pow(r.Imaginary, 2));
            double imaginary = (0 - l * r.Imaginary) / (Math.Pow(r.Really, 2) + Math.Pow(r.Imaginary, 2));
            return new Complex(really, imaginary);
        }
        public static Complex operator /(Complex l, int r)
        {
            double really = (l.Really * r) / (Math.Pow(r, 2));
            double imaginary = (l.Imaginary * r) / (Math.Pow(r, 2));
            return new Complex(really, imaginary);
        }
        public override string ToString()
        {
            if (Imaginary < 0)
                return $"{Math.Round(Really, 2)} - {Math.Round(Math.Abs(Imaginary), 2)}i";
            return $"{Math.Round(Really, 2)} + {Math.Round(Imaginary, 2)}i";
        }
    }
}
