namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;

public class RemoveTagCommand
{
    public RemoveTagCommand(int tagId)
    {
        TagId = tagId;
    }

    public int TagId { get; set; }
}