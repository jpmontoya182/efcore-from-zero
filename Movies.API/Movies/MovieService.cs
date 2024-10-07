using FluentValidation;
using Movies.API.Contracts;
using Movies.API.Validation;

namespace Movies.API.Movies
{
    public class MovieService : IMovieService
    {
        private readonly IValidator<Movie> _validator;
        private readonly List<Movie> _movies = new();


        public MovieService(IValidator<Movie> validator)
        {
            _validator = validator;
        }

        public async Task<Result<Movie, ValidationFailed>> Create(Movie movie)
        { 
            var validationResult = await _validator.ValidateAsync(movie);
            if (!validationResult.IsValid)
            {
                return new ValidationFailed(validationResult.Errors);
            }
            _movies.Add(movie);
            return movie;
        }

        public async Task<Movie?> GetById(Guid id)
        { 
            return _movies.SingleOrDefault(x => x.Id  == id);
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return _movies;
        }

        public async Task<Result<Movie?, ValidationFailed>> Update(Movie movie)
        {
            var validationResult = await _validator.ValidateAsync(movie);
            if (!validationResult.IsValid)
            {
                return new ValidationFailed(validationResult.Errors);
            }

            var existingMovie = await GetById(movie.Id);
            if (existingMovie is null)
            {
                return default(Movie);
            }

            _movies.Remove(existingMovie);
            _movies.Add(movie);
            return movie;

        }

        public async Task<bool> DeleteById(Guid id)
        { 
            var result = _movies.RemoveAll(x => x.Id == id);
            return result > 0;
        }

       
    }
}
