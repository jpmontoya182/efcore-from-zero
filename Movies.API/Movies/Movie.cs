using System.ComponentModel.DataAnnotations;

namespace Movies.API.Movies
{
    public class Movie
    {
        [Key]
        public required Guid Id { get; set; }
        public required string Title { get; set; }
        public required int YearOfRelease { get; set; }
    }
}
