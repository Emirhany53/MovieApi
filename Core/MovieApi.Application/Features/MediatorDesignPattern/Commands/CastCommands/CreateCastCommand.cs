using MediatR;

namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;

public class CreateCastCommand: IRequest
{
    public required string Title { get; set; }
    public required string Name  {get; set;}
    public required string Surname {get; set;}
    public required string ImageUrl {get; set;}
    public string? Overview {get; set;}
    public string? Biography {get; set;}
}
