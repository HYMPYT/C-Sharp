using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    class MyInitializer : CreateDatabaseIfNotExists<BookShopContext>
    {
        protected override void Seed(BookShopContext context)
        {
            Book b1 = new Book { Title = "За двумя зайцами" };
            Book b2 = new Book { Title = "Крёстный отец" };
            Book b3 = new Book { Title = "Граф Монте-Кристо" };
            Book b4 = new Book { Title = "Пролетая над гнездом кукушки" };
            Book b5 = new Book { Title = "Гарри Поттер" };
            Book b6 = new Book { Title = "Язык программирования С" };
            Author a1 = new Author { Name = "Джоан", LastName = "Роулинг" };
            Author a2 = new Author { Name = "Алекандр", LastName = "Дюма" };
            Author a3 = new Author { Name = "Кен", LastName = "Кизи" };
            Author a4 = new Author { Name = "Деннис", LastName = "Ричи" };
            b1.Authors.Add(a4);
            b1.Authors.Add(a1);
            b2.Authors.Add(a3);
            b3.Authors.Add(a2);
            b4.Authors.Add(a1);
            b5.Authors.Add(a4);
            b6.Authors.Add(a1);
            a1.Books.Add(b1);
            a1.Books.Add(b4);
            a1.Books.Add(b6);
            a2.Books.Add(b3);
            a3.Books.Add(b2);
            a4.Books.Add(b1);
            a4.Books.Add(b5);

            context.Books.AddRange(new List<Book> { b1, b2, b3, b4, b5, b6 });
            context.Authors.AddRange(new List<Author> { a1, a2, a3, a4 });

            context.SaveChanges();
        }
}
public class BookShopContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public BookShopContext() : base("name=BooksAuthorsCS")
    {
        Database.SetInitializer(new MyInitializer());
    }
}
}
