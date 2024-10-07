using Movies.API.Movies;
using Movies.API.Validation;

namespace Movies.API.Contracts;

public interface IMovieService
{
    Task<Result<Movie, ValidationFailed>> Create(Movie movie);
    Task<Movie?> GetById(Guid id);
    Task<IEnumerable<Movie>> GetAll();
    Task<Result<Movie?, ValidationFailed>> Update(Movie movie);
    Task<bool> DeleteById(Guid id);
}
