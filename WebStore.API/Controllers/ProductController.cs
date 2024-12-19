using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebStore.Application.Usecases.Products.Commands.Create;

namespace WebStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController(IMediator mediator): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ProductCreateCommand command)
    {
        await mediator.Send(command);

        return Ok();
    }
}
