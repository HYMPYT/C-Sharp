using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка_операторов
{
    class MyNumber
    {
        public int Num { get; set; }

        public MyNumber(int value)
        {
            Num = value;
        }
        public MyNumber() : this(0) { }
        public override string ToString()
        {
            return $"{Num}";
        }
        public static MyNumber operator*(MyNumber r, Fraction l)
        {
            return new MyNumber(l.Num * r.Num / l.Denum);
        }
    }
}