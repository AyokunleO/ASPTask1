using ASPTask1.Models;
using ASPTask1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTask1.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookService bookService;

        public HomeController(BookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Books()
        {
            IEnumerable<Book> books = bookService.GetBooks();
            return View(books);
        }
        [HttpGet]
        public IActionResult SearchBook()
        {
            return View(new Book());
        }


        public IActionResult DisplayBook(Book book)
        {
            string bookSearched = book.Title;
            var result = bookService.GetBook(bookSearched);
            return View(result);
        }
        public IActionResult Book(int id)
        {
            Book info = bookService.GetBook(id);
            return View(info);
        }
        [HttpGet]
        public IActionResult EnterBook()
        {
            return View(new Book());
        }
        [HttpPost]
        public IActionResult EnterBook(Book book)
        {
            Book book1 = new Book
            {
                Isbn = book.Isbn,
                Title = book.Title,
                Author = book.Author,
                Edition = book.Edition,
                Publication = book.Publication
            };
            bookService.AddBook(book1);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
