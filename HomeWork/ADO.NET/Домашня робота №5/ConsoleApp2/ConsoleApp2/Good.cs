using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Good
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            return $"Title: {Title}\nPrice: {Price}\nCategory: {Category}";
        }
    }
}
