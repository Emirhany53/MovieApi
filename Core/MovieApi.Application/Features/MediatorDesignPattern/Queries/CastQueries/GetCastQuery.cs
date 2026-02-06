using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieApi.Domain.Entities;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;

public class GetCastQuery:IRequest<List<GetCastQueryResult>>, IRequest<Category>, IRequest<GetCastQueryHandler>, IRequest<List<GetCastQueryHandler>>
{
    public int CastId { get; set; }
    public required string Title { get; set; }
    public required string Name  {get; set;}
    public required string Surname {get; set;}
    public required string ImageUrl {get; set;}
    public string? Overview {get; set;}
    public string? Biography {get; set;}
}