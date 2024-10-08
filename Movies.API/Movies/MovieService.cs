using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Movies.API.Contracts;
using Movies.API.Data;
using Movies.API.Validation;

namespace Movies.API.Movies
{
    //public class MovieService : IMovieService
    //{
    //    private readonly IValidator<Movie> _validator;
    //    private readonly AppDbContext _dbContext;

    //    public MovieService(IValidator<Movie> validator, AppDbContext dbContext)
    //    {
    //        _validator = validator;
    //        _dbContext = dbContext;
    //    }

    //    public async Task<Result<Movie, ValidationFailed>> Create(Movie movie)
    //    { 
    //        var validationResult = await _validator.ValidateAsync(movie);
    //        if (!validationResult.IsValid)
    //        {
    //            return new ValidationFailed(validationResult.Errors);
    //        }

    //        _dbContext.Movies.Add(movie);
    //        await _dbContext.SaveChangesAsync();

    //        return movie;
    //    }

    //    public async Task<Movie?> GetById(Guid id)
    //    { 
    //        return await _dbContext.Movies.FindAsync(id);        
    //    }

    //    public async Task<IEnumerable<Movie>> GetAll()
    //    {
    //        return await _dbContext.Movies
    //            .AsNoTracking()
    //            .ToListAsync();
    //    }

    //    public async Task<Result<Movie?, ValidationFailed>> Update(Movie movie)
    //    {
    //        var validationResult = await _validator.ValidateAsync(movie);
    //        if (!validationResult.IsValid)
    //        {
    //            return new ValidationFailed(validationResult.Errors);
    //        }

    //        _dbContext.Movies.Update(movie);
    //        var result = await _dbContext.SaveChangesAsync();
    //        return result > 0 ? movie : default(Movie);
    //    }

    //    public async Task<bool> DeleteById(Guid id)
    //    {
    //        var result = await _dbContext.Movies
    //            .Where(x => x.Id == id)
    //            .ExecuteDeleteAsync();
    //        return result > 0;
    //    }

       
    //}
}
