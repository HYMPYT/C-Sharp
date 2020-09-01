using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Models
{
    class MyTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string About { get; set; }
        public string Term { get; set; }
        public int CategoryId { get; set; }
    }
}
