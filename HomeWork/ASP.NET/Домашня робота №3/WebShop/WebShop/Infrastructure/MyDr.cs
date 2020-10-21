using DAL.Context;
using DAL.Repositories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Infrastructure
{
    public class MyDR : IDependencyResolver
    {
        IKernel kernel;
        public MyDR()
        {
            kernel = new StandardKernel();
            kernel.Bind<IRepository<Good>>().To<GoodRepository>();
            kernel.Bind<IRepository<Manufacturer>>().To<ManufacturerRepository>();
            kernel.Bind<IRepository<Category>>().To<CategoryRepository>();
            kernel.Bind<DbContext>().To<ShopContext>();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}