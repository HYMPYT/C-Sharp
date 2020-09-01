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
            Book b5 = new Book { Title = "Язык программирования С" };
            Book b6 = new Book { Title = "Гарри Поттер" };
            Book b7 = new Book { Title = "Три мушкетёра" };
            Author a1 = new Author { Name = "Джоан", Lastname = "Роулинг" };
            Author a2 = new Author { Name = "Александр", Lastname = "Дюма" };
            Author a3 = new Author { Name = "Кен", Lastname = "Кизи" };
            Author a4 = new Author { Name = "Деннис", Lastname = "Ричи" };
            Author a5 = new Author { Name = "Брайан", Lastname = "Керниган" };
            Author a6 = new Author { Name = "Марио", Lastname = "Пьюзо" };
            Author a7 = new Author { Name = "Илья", Lastname = "Ильф" };
            Author a8 = new Author { Name = "Евгений", Lastname = "Петров" };

            b1.Authors.Add(a7);
            b1.Authors.Add(a8);
            b2.Authors.Add(a6);
            b3.Authors.Add(a2);
            b4.Authors.Add(a3);
            b5.Authors.Add(a4);
            b5.Authors.Add(a5);
            b6.Authors.Add(a1);
            b7.Authors.Add(a2);
            a1.Books.Add(b6);
            a2.Books.Add(b3);
            a2.Books.Add(b7);
            a3.Books.Add(b4);
            a4.Books.Add(b5);
            a5.Books.Add(b5);
            a6.Books.Add(b2);
            a7.Books.Add(b1);
            a8.Books.Add(b1);

            context.Books.AddRange(new List<Book> { b1, b2, b3, b4, b5, b6 });
            context.Authors.AddRange(new List<Author> { a1, a2, a3, a4, a5, a6, a7, a8 });

            context.SaveChanges();

        }
    }
    public class BookShopContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public BookShopContext():base("name=BooksAuthorsCS")
        {
            Database.SetInitializer(new MyInitializer());
        }


    }
}
