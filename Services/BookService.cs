using ASPTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTask1.Services
{
    public class BookService
    {
        private static ICollection<Book> books;
        public BookService()
        {
            books = new List<Book>();
        }

        public IEnumerable<Book> GetBooks()
        {
            return books.ToList();
        }

        public Book GetBook(int id)
        {
            Book book = books.FirstOrDefault(b => b.Id == id);
            return book;
        }
        public Book GetBook(string title)
        {
            Book book = books.FirstOrDefault(b => b.Title == title);
            return book;
        }

        public void AddBook(Book book)
        {
            book.Id = GetNextId();
            books.Add(book);
        }

        private int GetNextId()
        {
            Book book = books.LastOrDefault();
            if(book != null)
            {
                return book.Id + 1;
            } return 1;
        }
    }
}
