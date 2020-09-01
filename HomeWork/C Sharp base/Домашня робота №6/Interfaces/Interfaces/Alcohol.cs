using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Alcohol : Food, IBreakableGoods, IFlammableGoods, IExciseTheProducts
    {
        public DateTime ExpirationDate { get; set; }
        public string Status { get; set; }
        public Alcohol(int id, string name, string status, DateTime expirationDate, DateTime productionDate) : base(id, name, productionDate)
        {
            ExpirationDate = expirationDate;
            Status = status;
        }
        public override string ToString()
        {
            return $"Status: {Status}\n" +
                $"Name: {Name}\n" +
                $"Info: {InfoF()}\n" +
                $"      {InfoB()}\n" +
                $"      {InfoE()}\n" +
                $"Expiration date: {ExpirationDate.ToLongDateString()}\n" +
                $"Production date: {ProductionDate.ToLongDateString()}\n";
        }
        public string InfoF()
        {
            return $"{Name} is flammable good";
        }
        public string InfoB()
        {
            return $"{Name} is breakable good";
        }
        public string InfoE()
        {
            return $"{Name} is excise product";
        }
        public bool Check(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Alcohol))
                return false;

            return string.Compare(((Alcohol)obj).Status, "Broken") == 0;
        }
    }
}