using bookish.Models.Database;

namespace bookish.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        public string? Blurb { get; set; }

        public int YearPublished { get; set; }
        public string? ImageUrl { get; set; }
        public AuthorDbModel? Author { get; set; }


    }
}