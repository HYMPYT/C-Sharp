using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        DbContext context;
        DbSet<T> dbset;
        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbset = context.Set<T>();
        }
        public int ITEMS_PER_PAGE { get => 7; }

        public int PagesCount
        {
            get => (int)Math.Ceiling(dbset.ToList().Count / (decimal)ITEMS_PER_PAGE);
        }

        public void CreateOrUpdate(T entity)
        {
            dbset.AddOrUpdate(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbset.Remove(entity);
            context.SaveChanges();
        }

        public T Get(int id)
        {
            return dbset.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return dbset;
        }
    }
}
