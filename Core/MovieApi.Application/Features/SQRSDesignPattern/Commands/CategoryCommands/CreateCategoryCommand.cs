namespace MovieApi.Application.Features.SQRSDesignPattern.Commands.CategoryCommands;

public class CreateCategoryCommand
{
    public required string CategoryName { get; set; }
}