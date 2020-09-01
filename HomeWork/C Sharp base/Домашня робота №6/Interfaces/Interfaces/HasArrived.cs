using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class HasArrived
    {
        Product[] _arrived;
        public HasArrived(int size)
        {
            _arrived = new Product[size];
        }
        public HasArrived(int size, Product[] arr)
        {
            _arrived = new Product[size];
            _arrived = arr;
        }
        public HasArrived() : this(0) { }
        public int Length => _arrived.Length;
        public void Add(int id, string name, string status, DateTime expirationDate, DateTime productionDate)
        {
            int newSize = Length + 1;
            Array.Resize(ref _arrived, newSize);
            switch (id)
            {
                case 0:
                    _arrived[Length - 1] = new Alcohol(id, name, status, expirationDate, productionDate);
                    break;
                case 1:
                    _arrived[Length - 1] = new MilkProducts(id, name, expirationDate, productionDate);
                    break;
                case 2:
                    _arrived[Length - 1] = new Fruits(id, name, expirationDate, productionDate);
                    break;
                case 3:
                    _arrived[Length - 1] = new AirFreshener(id, name, expirationDate, productionDate);
                    break;
                case 4:
                    _arrived[Length - 1] = new GlassCleaner(id, name, expirationDate, productionDate);
                    break;
            }
        }
        public void Delete(HasArrived obj, int index)
        {
            if (index < 0)
                return;
            if (obj.Length <= index)
                return;
            Array.Copy(_arrived, index + 1, _arrived, index, Length - index - 1);
            Array.Resize(ref _arrived, Length - 1);
        }
        public Product this[int index]
        {
            get => _arrived[index];
            set => _arrived[index] = value;
        }
        public void Print()
        {
            foreach (var item in _arrived)
            {
                Console.WriteLine(item);
            }
        }
    }
}
