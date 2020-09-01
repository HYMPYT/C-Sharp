using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
