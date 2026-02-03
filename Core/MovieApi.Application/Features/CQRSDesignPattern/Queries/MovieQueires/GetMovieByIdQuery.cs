namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueires;

public class GetMovieByIdQuery
{
    public GetMovieByIdQuery(int movieId)
    {
        MovieId = movieId;
    }

    public int MovieId { get; set; }
}