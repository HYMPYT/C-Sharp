using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Laptop
    {
        string _brand;
        double _screenDiagonal;
        double _weight;
        string _producingCountry;
        public Laptop(string brand, double screenDiagonal, double weight, string producingCountry)
        {
            _brand = brand;
            _screenDiagonal = screenDiagonal;
            _weight = weight;
            _producingCountry = producingCountry;
        }
        public Laptop():this("Noname", 0, 0, "Noname") { }
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }
        public double ScreenDiagonal
        {
            get => _screenDiagonal;
            set => _screenDiagonal = value;
        }
        public double Weight
        {
            get => _weight;
            set => _weight = value;
        }
        public string ProducingCountry
        {
            get => _producingCountry;
            set => _producingCountry = value;
        }
        public override string ToString()
        {
            return $"Brand: {_brand}\n" +
                $"Screen diagonal: {_screenDiagonal}\n" +
                $"Weight: {_weight} kg\n" +
                $"Producing country: {_producingCountry}\n";
        }
    }
}
