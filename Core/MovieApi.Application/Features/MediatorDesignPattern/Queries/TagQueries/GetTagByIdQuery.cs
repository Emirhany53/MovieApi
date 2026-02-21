using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Results.TagResults;
using MovieApi.Domain.Entities;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries;

public class GetTagByIdQuery:IRequest<List<GetTagByIdQueryResult>>
{
    public int Id { get; set; }
    
    public GetTagByIdQuery(int id)
    {
        Id = id;
    }
    
}