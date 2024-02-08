using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Servises
{
    public class BookService : IBookRepository
    {
        private static List<Book> books = new List<Book>()
        {
            new Book
            {
                Id = 1,
                Name = "Sariq devni minib",
                Price = 10000,
                Author = "X.Toxtaboyev",
                TimeOfWriting = DateTime.UtcNow.AddHours(5),
                Created = DateTime.UtcNow.AddHours(5)
            }
        };
        public Task<Book> CreateBook(Book newBook)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> FirstBook(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetBooks()
            => await Task.FromResult(books);

        public Task<Book> UpdateBook(Book newBook)
        {
            throw new NotImplementedException();
        }
    }
}
