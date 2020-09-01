using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Food : Product
    {
        public DateTime ProductionDate { get; set; }
        public Food(int id, string name, DateTime productionDate) : base(id, name)
        {
            ProductionDate = productionDate;
        }
    }
}