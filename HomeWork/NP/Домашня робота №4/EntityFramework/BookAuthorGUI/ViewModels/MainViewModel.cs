using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
using DAL.Repositories;

namespace BookAuthorGUI.ViewModels
{
    class MainViewModel
    {
        BookRepository bookRepository;
        AuthorRepository authorRepository;
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        public MainViewModel()
        {
            bookRepository = new BookRepository();
            Books = bookRepository.GetAll().ToList();

            authorRepository = new AuthorRepository();
            Authors = authorRepository.GetAll().ToList();
        }
    }
}
