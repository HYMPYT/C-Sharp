using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyBrowser
{
    class DataManager : DbContext
    {
        public DataManager() : base("Default")
        { }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Site> Sites { get; set; }
    }
}
