using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        //навигационные ссылки:
        public virtual List<Product> Products { get; set; }
    }
}
