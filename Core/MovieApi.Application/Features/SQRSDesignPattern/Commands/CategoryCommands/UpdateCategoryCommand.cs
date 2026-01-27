namespace MovieApi.Application.Features.SQRSDesignPattern.Commands.CategoryCommands;

public class UpdateCategoryCommand
{
    public int CategoryId { get; set; }
    public required string CategoryName { get; set; }
}