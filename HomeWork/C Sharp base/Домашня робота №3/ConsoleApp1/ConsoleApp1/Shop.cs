using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shop
    {
        private Laptop[] _arr;
        public Shop(int size)
        {
            _arr = new Laptop[size];
        }
        public Shop()
        {
            _arr = new Laptop[5]
            {
                new Laptop("ASUS", 15.6, 1.86, "USA"),
                new Laptop("MSI", 15.6, 2.15, "China"),
                new Laptop("HP", 13.6, 1.45, "China"),
                new Laptop("Lenovo", 14.5, 2.45, "Germany"),
                new Laptop("Apple", 15.6, 1.45, "USA")
            };
        }
        public int Length => _arr.Length;
        public Laptop this[int index]
        {
            get => _arr[index];
            set => _arr[index] = value;
        }
    }
}
