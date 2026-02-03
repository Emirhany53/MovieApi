namespace MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;

public class GetMovieByIdQueryResult
{
    public int MovieId { get; set; }
    public required string Title { get; set; }
    public required string CoverImageUrl { get; set; }
    public decimal Rating { get; set; }
    public required string Description { get; set; }
    public int Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int CreatedYear { get; set; }
    public bool Status { get; set; }
}