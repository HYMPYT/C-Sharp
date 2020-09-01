using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class WrittenOfGoods
    {
        Product[] _written;
        public int Length => _written.Length;
        public WrittenOfGoods()
        {
            _written = new Product[0];
        }
        public void Add(Product obj)
        {
            if (obj == null)
                return;
            Array.Resize(ref _written, Length + 1);
            _written[Length - 1] = obj;
        }
        public void Delete(WrittenOfGoods obj, int index)
        {
            if (index < 0)
                return;
            if (obj.Length <= index)
                return;
            Array.Copy(_written, index + 1, _written, index, Length - index - 1);
            Array.Resize(ref _written, Length - 1);
        }
        public void DeleteAll(WrittenOfGoods obj)
        {
            Array.Clear(_written, 0, Length);
        }
        public Product this[int index]
        {
            get => _written[index];
            set => _written[index] = value;
        }
        public void Print()
        {
            foreach (var item in _written)
            {
                Console.WriteLine(item);
            }
        }
    }
}
