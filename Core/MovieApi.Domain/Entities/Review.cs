namespace MovieApi.Domain.Entites;

public class Review
{
    public int ReviewId { get; set; }
    public String ReviewComment { get; set; }
    public int UserRating { get; set; }
    public DateTime CommentDate { get; set; }
    public bool Status { get; set; }
}