namespace DeliveryService.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DeliveryServiceModel : DbContext
    {
        public DeliveryServiceModel()
            : base("name=DeliveryServiceModel")
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}