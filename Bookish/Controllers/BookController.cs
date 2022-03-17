using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models.Requests;
using bookish.Models.Response;
using bookish.Services;
using bookish.Repositories;

namespace bookish.Controllers
{
    public class BookController : Controller
    {
            private readonly ILogger<HomeController> _logger;
            private readonly IBookService _bookService;

            private readonly IBookRepo _books;

    public BookController(ILogger<HomeController> logger, IBookService bookService, IBookRepo books)
        {
            _logger = logger;
            _bookService = bookService;
            _books = books;
        }

    [HttpPost("create")]
    public IActionResult Create([FromBody] CreateBookRequest newBook)
        {
            var book = _books.Create(newBook);
            return Created("/Home/Booklist", book);
        }
    }

}