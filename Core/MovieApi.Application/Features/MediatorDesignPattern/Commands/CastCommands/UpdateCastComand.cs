using MediatR;

namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;

public class UpdateCastComand:IRequest
{
    public int CastId { get; set; }
    public required string Title { get; set; }
    public required string Name  {get; set;}
    public required string Surname {get; set;}
    public required string ImageUrl {get; set;}
    public string? Overview {get; set;}
    public string? Biography {get; set;}
}