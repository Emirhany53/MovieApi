using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Persistence.Context;
using NuGet.Protocol.Plugins;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class CreateCastCommandHandler:IRequestHandler<CreateCastCommand>
{
    private readonly MovieContext _context;

    public CreateCastCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}