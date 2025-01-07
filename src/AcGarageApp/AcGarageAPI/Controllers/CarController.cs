using System.ComponentModel.DataAnnotations;
using AcGarageAPI.CQS.Commands;
using AcGarageAPI.DtoModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AcGarageAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> PostCar([FromBody, Required] CarDto input)
    {
        await mediator.Send(new CreateCar(input));

        return Ok();
    }
}