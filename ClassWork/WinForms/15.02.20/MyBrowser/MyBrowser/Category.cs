using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBrowser
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Site> Sites { get; set; }

    }
}
