using DAL.Context;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            BookRepository repo = new BookRepository();
            foreach (var book in repo.GetAll())
            {
                Console.WriteLine(book.Title);
            }

            //using (BookShopContext db = new BookShopContext())
            //{
            //    Author duma = db.Authors.FirstOrDefault(x => x.LastName.ToLower() == "дюма");
            //    foreach (var book in duma.Books)
            //    {
            //        Console.WriteLine(book.Title);
            //    }
            //}
        }
    }
}
