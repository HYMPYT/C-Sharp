using DAL.Context;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AuthorRepository
    {
        BookShopContext db = new BookShopContext();

        public Author Get(int id)
        {
            return db.Authors.FirstOrDefault(x => x.AuthorId == id);
        }

        public IEnumerable<Author> GetAll()
        {
            return db.Authors;
        }

        public void CreateOrUpdate(Author author)
        {
            db.Authors.AddOrUpdate(author);
        }

        public void Delete(Author author)
        {
            db.Authors.Remove(author);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
