using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers;
using MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueires;

namespace MovieApi.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly GetMovieByIdQueryHandler _getMovieByIdQueryHandler;
    private readonly CreateMovieCommandHandler _createMovieCommandHandler;
    private readonly UpdateMovieCommandHandler _updateMovieCommandHandler;
    private readonly RemoveMovieCommandHandler _removeMovieCommandHandler;
    private readonly GetMovieQueryHandler _getMovieQueryHandler;


    public MoviesController(GetMovieByIdQueryHandler getMovieByIdQueryHandler, CreateMovieCommandHandler createMovieCommandHandler, UpdateMovieCommandHandler updateMovieCommandHandler, RemoveMovieCommandHandler removeMovieCommandHandler, GetMovieQueryHandler getMovieQueryHandler)
    {
        _getMovieByIdQueryHandler = getMovieByIdQueryHandler;
        _createMovieCommandHandler = createMovieCommandHandler;
        _updateMovieCommandHandler = updateMovieCommandHandler;
        _removeMovieCommandHandler = removeMovieCommandHandler;
        _getMovieQueryHandler = getMovieQueryHandler;
    }

    [HttpGet]
    public async Task<IActionResult> MovieList()
    {
        var value = await _getMovieQueryHandler.Handle();
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateMovie(CreateMovieCommand command)
    {
        await _createMovieCommandHandler.Handle(command);
        return Ok("Film Eklme işlemi başarılı");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteMovie(int id)
    {
        await _removeMovieCommandHandler.Handle(new RemoveMovieCommand(id));
        return Ok("Silme islemi gerceklestirildi");
    }

    [HttpGet("GetMovie")]
    public async Task<IActionResult> GetMovie(int id)
    {
        var value = await _getMovieByIdQueryHandler.Handle(new GetMovieByIdQuery(id));
        return Ok(value);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateMovie(UpdateMovieCommand command)
    {
        await _updateMovieCommandHandler.Handle(command);
        return Ok("Film Guncelleme Basarili");
    }
}