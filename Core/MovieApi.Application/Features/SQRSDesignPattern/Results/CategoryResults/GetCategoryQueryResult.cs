namespace MovieApi.Application.Features.SQRSDesignPattern.Results.CategoryResults;

public class GetCategoryQueryResult
{
    public int CategoryId { get; set; }
    public required string CategoryName { get; set; }
}