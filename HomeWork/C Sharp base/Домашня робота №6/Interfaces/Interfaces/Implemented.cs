using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Implemented
    {
        Product[] _implemented;
        public int Length => _implemented.Length;
        public Implemented(HasArrived obj)
        {
            _implemented = new Product[obj.Length];
            for(int i = 0; i< obj.Length; i++)
            {
                _implemented[i] = obj[i];
            }
        }
        public Implemented()
        {
            _implemented = new Product[0];
        }
        public void Add(int index, Product[] arr)
        {
            if (index < 0)
                return;
            if (arr.Length <= index)
                return;
            if (arr == null)
                return;
            Array.Resize(ref _implemented, Length + 1);
            _implemented[Length - 1] = arr[index];
        }
        public void Delete(Implemented obj, int index)
        {
            if (index < 0)
                return;
            if (obj.Length <= index)
                return;
            Array.Copy(_implemented, index + 1, _implemented, index, Length - index - 1);
            Array.Resize(ref _implemented, Length - 1);
        }
        public Product this[int index]
        {
            get => _implemented[index];
            set => _implemented[index] = value;
        }
        public void Print()
        {
            foreach (var item in _implemented)
            {
                Console.WriteLine(item);
            }
        }
    }
}
