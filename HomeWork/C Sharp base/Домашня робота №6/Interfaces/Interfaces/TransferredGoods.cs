using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class TransferredGoods
    {
        Product[] _transferred;
        public int Length => _transferred.Length;
        public TransferredGoods(WrittenOfGoods obj)
        {
            _transferred = new Product[obj.Length];
            for (int i = 0; i < obj.Length; i++)
            {
                _transferred[i] = obj[i];
            }
        }
        public TransferredGoods()
        {
            _transferred = new Product[0];
        }
        public void Add(int index, WrittenOfGoods obj)
        {
            if (obj == null)
                return;
            Array.Resize(ref _transferred, Length + 1);
            _transferred[Length - 1] = obj[index];
        }
        public void Delete(TransferredGoods obj, int index)
        {
            if (index < 0)
                return;
            if (obj.Length <= index)
                return;
            Array.Copy(_transferred, index + 1, _transferred, index, Length - index - 1);
            Array.Resize(ref _transferred, Length - 1);
        }
        public Product this[int index]
        {
            get => _transferred[index];
            set => _transferred[index] = value;
        }
        public void Print()
        {
            foreach (var item in _transferred)
            {
                Console.WriteLine(item);
            }
        }
    }
}
