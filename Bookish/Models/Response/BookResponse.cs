using System;
using bookish.Models.Database;

namespace bookish.Models.Response
{

    public class BookResponse
    {
        private readonly Book _book;

        public BookResponse(Book book)
            {
                _book = book;
            }
        
        public int Id => _book.Id;
        public string Title => _book.Title;
        public int YearPublished => _book.YearPublished;
        public string ImageUrl => _book.ImageUrl;
        public string Blurb => _book.Blurb;

        public AuthorDbModel Author => _book.Author; 

    }
}

// lic string? Title { get; set; }

//         public int YearPublished { get; set; }
//         public string? Author { get; set; }

//         public string? ImageUrl { get; set; }

//         public string? Blurb { get; set; }