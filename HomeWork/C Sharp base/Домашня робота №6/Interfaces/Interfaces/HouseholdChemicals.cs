using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class HouseholdChemicals : Product
    {
        public DateTime ProductionDate { get; set; }
        public HouseholdChemicals(int id, string name, DateTime productionDate) : base(id, name)
        {
            ProductionDate = productionDate;
        }
    }
}