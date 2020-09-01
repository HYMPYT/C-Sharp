using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерфейсы_2
{
    class Figure : IComparable
    {
        public string Type { get; set; }
        double[] _sides;
        public Figure(string type, params double[] arr)
        {
            Type = type;
            _sides = arr;
        }
        public double this[int index]
        {
            get => _sides[index];
            set => _sides[index] = value;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Type = {Type}\nSides: ");
            foreach (var item in _sides)
            {
                sb.Append($"{item}, ");
            }
            return sb.ToString().Substring(0, sb.ToString().Length - 2);
        }
        public int CompareTo(object obj)
        {
            return _sides.Length.CompareTo(((Figure)obj)._sides.Length);
        }
    }

    class Canvas : IEnumerator
    {
        Random _rnd = new Random();
        Figure[] _arr;
        public Canvas(int s)
        {
            _arr = new Figure[s];
            for (int i = 0; i < _arr.Length; i++)
            {
                switch (_rnd.Next(4))
                {
                    case 0:
                        _arr[i] = new Figure("Triangle", _rnd.Next(10), _rnd.Next(10), _rnd.Next(10));
                        break;
                    case 1:
                        _arr[i] = new Figure("Rectangle", _rnd.Next(10), _rnd.Next(10), _rnd.Next(10), _rnd.Next(10));
                        break;
                    case 2:
                        _arr[i] = new Figure("Pentagon", _rnd.Next(10), _rnd.Next(10), _rnd.Next(10), _rnd.Next(10), _rnd.Next(10));
                        break;
                    case 3:
                        _arr[i] = new Figure("Hexagon", _rnd.Next(10), _rnd.Next(10), _rnd.Next(10), _rnd.Next(10), _rnd.Next(10), _rnd.Next(10));
                        break;
                }
            }
        }
        public int Length => _arr.Length;

        public object Current => throw new NotImplementedException();

        public Figure this[int index]
        {
            get => _arr[index];
            set => _arr[index] = value;
        }
        public void Sort()
        {
            Array.Sort(_arr);
        }
        public IEnumerator GetEnumerator()
        {
            return _arr.GetEnumerator();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canv = new Canvas(12);
            for(int  i = 0; i< canv.Length; i++)
            {
                Console.WriteLine(canv[i]);
            }
            Console.WriteLine("++++++++++++++++++++++++");
            canv.Sort();
            //for (int i = 0; i < canv.Length; i++)
            //{
            //    Console.WriteLine(canv[i]);
            //}

            foreach(var item in canv)
            {
                Console.WriteLine(item);
            }
        }
    }
}
