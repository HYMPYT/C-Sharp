using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models
{
    public class Product
    {
        //свойства класса  product ......

        //навигационные ссылки:
        public virtual List<Order> Orders { get; set; }
    }
}
