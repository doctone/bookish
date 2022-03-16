using System.ComponentModel.DataAnnotations;

namespace bookish.Models.Requests
{
    public class CreateBookRequest
    {
        [Required]
        [StringLength(140)]

        public string Title { get; set; }

        [Required]
        [StringLength(60)]
        public string Author {get; set; }

        public string ImageUrl { get; set; }

        public DateTime DatePublished { get; set; }

    }
}