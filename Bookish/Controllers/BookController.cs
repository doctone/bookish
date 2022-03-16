using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models.Requests;
using bookish.Services;

namespace bookish.Controllers
{
    public class BookController : Controller
    {
            private readonly ILogger<HomeController> _logger;
            private readonly IBookService _bookService;

    public BookController(ILogger<HomeController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }
    }

    [HttpPost("create")]
    public IActionResult Create([FromBody] CreateBookRequest newBook)
    {

    }
}