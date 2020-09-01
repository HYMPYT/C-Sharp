using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class AirFreshener : HouseholdChemicals, IFlammableGoods
    {
        public DateTime ExpirationDate { get; set; }
        public AirFreshener(int id, string name, DateTime expirationDate, DateTime productionDate) : base(id, name, productionDate)
        {
            ExpirationDate = expirationDate;
        }
        public string InfoF()
        {
           return $"{Name} is flammable good";
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Expiration date: {ExpirationDate.ToLongDateString()}\n" +
                $"Production date: {ProductionDate.ToLongDateString()}\n" +
                $"Info: {InfoF()}\n";
        }
    }
}