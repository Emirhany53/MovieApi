namespace MovieApi.Domain.Entities;

public class Review
{
    public int ReviewId { get; set; }
    public required string ReviewComment { get; set; }
    public int UserRating { get; set; }
    public DateTime CommentDate { get; set; }
    public bool Status { get; set; }
}