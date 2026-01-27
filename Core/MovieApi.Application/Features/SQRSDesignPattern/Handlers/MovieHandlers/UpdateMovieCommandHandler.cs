using MovieApi.Application.Features.SQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.SQRSDesignPattern.Handlers.MovieHandlers;

public class UpdateMovieCommandHandler
{
    private readonly MovieContext _context;

    public UpdateMovieCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async void Handler(UpdateMovieCommand command)
    {
        var value = await _context.Movies.FindAsync(command.MovieId);
        value.Rating = command.Rating;
        value.Description = command.Description;
        value.ReleaseDate = command.ReleaseDate;
        value.Status = command.Status;
        value.Duration = command.Duration;
        value.CoverImageUrl = command.CoverImageUrl;
        value.Title = command.Title;
        value.CreatedYear = command.CreatedYear;
        await _context.SaveChangesAsync();
    }
}