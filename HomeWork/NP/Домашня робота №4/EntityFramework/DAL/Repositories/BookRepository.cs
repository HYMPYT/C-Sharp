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
    public class BookRepository
    {
        BookShopContext db = new BookShopContext();
        public Book Get(int id)
        {
            return db.Books.FirstOrDefault(x => x.BookId == id);
        }
        public IEnumerable<Book> GetAll()
        {
            return db.Books;
        }
        public void CreateOrUpdate(Book book)
        {
            db.Books.AddOrUpdate(book);
        }
        public void Delete(Book book)
        {
            db.Books.Remove(book);
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}
