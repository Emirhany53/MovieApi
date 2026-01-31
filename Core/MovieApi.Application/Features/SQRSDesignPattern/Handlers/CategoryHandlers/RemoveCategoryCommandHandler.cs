using MovieApi.Application.Features.SQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.SQRSDesignPattern.Handlers.CategoryHandlers;

public class RemoveCategoryCommandHandler
{
    private readonly MovieContext _context;

    public RemoveCategoryCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(RemoveCategoryCommand command)
    {
        var value = await _context.Categories.FindAsync(command.CategoryId);
        _context.Categories.Remove(value);
        await _context.SaveChangesAsync();
    }
}