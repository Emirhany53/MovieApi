using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;

namespace MovieApi.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CastsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CastsController(IMediator mediator) /*CQRS de yaptığımız uzun uzun tanımlamaları artık bu Mediator hallediyor.*/
    {
        _mediator = mediator;
    }

    [HttpGet]
    public IActionResult CastList() 
    {
        var value = _mediator.Send(new GetCastQuery());
        return Ok(value);
    }

    [HttpPost]
    public IActionResult CreateCast(CreateCastCommand command)
    {
        _mediator.Send(command);
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeleteCast(int id)
    {
        _mediator.Send(new RemoveCastCommand(id));
        return Ok();
    }

    [HttpGet("GetCastById")]
    public IActionResult GetCastById(int id)
    {
        var value = _mediator.Send(new GetCastByIdQuery(id));
        return Ok(value); 
    }

    [HttpPut]
    public IActionResult UpdateCast(UpdateCastComand command)
    {
        _mediator.Send(command);
        return Ok("Güncelleme işlemi başarılı");
    }
}