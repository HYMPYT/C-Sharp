using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class MilkProducts : Food, IPerishableProducts
    {
        public DateTime ExpirationDate { get; set; }
        public MilkProducts(int id, string name, DateTime expirationDate, DateTime productionDate) : base(id, name, productionDate)
        {
            int y = expirationDate.Year - productionDate.Year;
            int m = expirationDate.Month - productionDate.Month;
            int d = expirationDate.Day - productionDate.Day;

            if (y >= 0 && m >= 0 && d >= 0)
                ExpirationDate = expirationDate;
            else
                ExpirationDate = DateTime.Today;

            //if (m > 1 && expirationDate.Day >= productionDate.Day)
            //{
            //    ExpirationDate = new DateTime(expirationDate.Year, productionDate.Month, expirationDate.Day);
            //}
            //else
            //{
            //    if (m <= 1 && m > -1)
            //    {
            //        if (d > 14 || d < 0)
            //            ExpirationDate = new DateTime(expirationDate.Year, expirationDate.Month, (productionDate.AddDays(14)).Day);
            //        else
            //            ExpirationDate = expirationDate;
            //    }
            //    else
            //        ExpirationDate = new DateTime(expirationDate.Year, (productionDate.AddDays(14)).Month, (productionDate.AddDays(14)).Day);
            //}
        }
        public string InfoP()
        {
            return $"{Name} is perishable product";
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Expiration date: {ExpirationDate.ToLongDateString()}\n" +
                $"Production date: {ProductionDate.ToLongDateString()}\n" +
                $"Info: {InfoP()}\n";
        }
        public bool CheckExpiraionDate(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is MilkProducts))
                return false;

            int y = ((MilkProducts)obj).ExpirationDate.Year - ((MilkProducts)obj).ProductionDate.Year;
            int m = ((MilkProducts)obj).ExpirationDate.Month - ((MilkProducts)obj).ProductionDate.Month;
            int d = ((MilkProducts)obj).ExpirationDate.Day - ((MilkProducts)obj).ProductionDate.Day;

            if (m > 1 && ExpirationDate.Day >= ProductionDate.Day)
            {
                return true;
            }
            else
            {
                if (m <= 1 && m > -1)
                {
                    if (d > 14 || d < 0)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }
        }
    }
}