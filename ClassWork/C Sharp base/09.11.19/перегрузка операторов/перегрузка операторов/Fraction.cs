using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка_операторов
{
    class Fraction
    {
        public int Num { get; set; }
        public int Denum { get; set; }
        public Fraction(int num, int denum)
        {
            Num = num;
            Denum = denum;
        }
        public Fraction() : this(0, 1) { }
        public override string ToString()
        {
            return $"{Num}/{Denum}";
        }
        public static Fraction operator *(Fraction l, Fraction r)
        {
            return new Fraction(l.Num * r.Num, l.Denum * r.Denum);
        }
        public static Fraction operator *(Fraction l, int r)
        {
            return new Fraction(l.Num * r, l.Denum);
        }
        public static Fraction operator *(int l, Fraction r)
        {
            return new Fraction(l * r.Num, r.Denum);
        }
        public static Fraction operator *(Fraction l, MyNumber r)
        {
            return new Fraction(l.Num * r.Num, l.Denum);
        }
        public static int Clm(int a, int b)
        {
            int max = a > b ? a : b;
            for (int i = max; ; i += max)
            {
                if (i % a == 0 && i % b == 0)
                    return i;
            }
        }
        public static Fraction operator +(Fraction l, Fraction r)
        {
            return new Fraction(l.Num * (Clm(l.Denum, r.Denum) / l.Denum) + r.Num * (Clm(l.Denum, r.Denum) / r.Denum), Clm(l.Denum, r.Denum));
        }
        public static Fraction operator +(Fraction l, int r)
        {
            return l + new Fraction(r, 1);
        }
        public static Fraction operator ++(Fraction obj)
        {
            obj.Num += obj.Denum;
            return obj;
        }
        public static Fraction operator !(Fraction obj)
        {
            (obj.Num, obj.Denum) = (obj.Denum, obj.Num);
            return obj;
        }
        public static bool operator ==(Fraction l, Fraction r)
        {
            int clm = Clm(l.Denum, r.Denum);
            int a = l.Num * clm / l.Denum;
            int b = r.Num * clm / r.Denum;
            return a == b;
        }
        public static bool operator >(Fraction l, Fraction r)
        {
            int clm = Clm(l.Denum, r.Denum);
            int a = l.Num * clm / l.Denum;
            int b = r.Num * clm / r.Denum;
            return a > b;
        }
        public static bool operator <(Fraction l, Fraction r)
        {
            return !(l > r || l == r);
        }
        public static bool operator >=(Fraction l, Fraction r)
        {
            return l > r || l == r;
        }
        public static bool operator <=(Fraction l, Fraction r)
        {
            return !(l > r);
        }
        public static bool operator true(Fraction obj)
        {
            return obj.Num != 0;
        }
        public static bool operator false(Fraction obj)
        {
            return obj.Num == 0;
        }
        public static explicit operator double(Fraction obj)
        {
            return (double)obj.Num / obj.Denum;
        }
        public static explicit operator Fraction(double val)
        {
            int tmp = (int)((val - (int)val) * 100);

            return new Fraction((int)val * 100 + tmp, 100);
        }
        public static Fraction operator &(Fraction l, Fraction r)
        {
            return l.Num != 0 && r.Num != 0 ? l : new Fraction();
        }
        public static bool operator !=(Fraction l, Fraction r)
        {
            return !(l == r);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is Fraction tmp)
            {
                return this == tmp;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Num.GetHashCode() * Denum.GetHashCode() + Num / Denum;
        }
    }
}