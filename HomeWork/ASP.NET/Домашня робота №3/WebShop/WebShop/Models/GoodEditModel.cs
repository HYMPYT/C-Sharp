using DAL.Context;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class GoodEditModel
    {
        public Good Good { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Manufacturer> Manufacturers { get; set; }
    }
}