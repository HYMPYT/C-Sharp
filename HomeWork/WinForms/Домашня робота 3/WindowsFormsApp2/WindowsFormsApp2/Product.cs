using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Product
    {
        public string Name { get; set; }

        public string Specifications { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }
        public Product(string name, string specifications, string description, decimal value)
        {
            Name = name;
            Specifications = specifications;
            Description = description;
            Value = value;
        }

    }
}
