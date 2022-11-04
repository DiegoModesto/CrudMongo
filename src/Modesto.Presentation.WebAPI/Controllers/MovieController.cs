using MediatR;
using Microsoft.AspNetCore.Mvc;
using Modesto.Presentation.WebAPI.Domain.Commands;
using Modesto.Presentation.WebAPI.Domain.Queries;
using Modesto.Presentation.WebAPI.Models;
using Modesto.Presentation.WebAPI.Services;

namespace Modesto.Presentation.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }
        

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> Get(string id, CancellationToken cancellationToken)
        {
            var query = new GetMovieByIdQuery(id);

            var result = await _mediator.Send(query, cancellationToken);

            return (result is null
                ? NotFound()
                : Ok(result));
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            var query = new GetAllMoviesQuery();

            var result = await _mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateMovieCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, [FromBody]UpdateMovieCommand command)
        {
            command.Id = id;
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var command = new DeleteMovieCommand(id);

            var response = await _mediator.Send(command);

            return response ? NoContent() : BadRequest();
        }
    }
}
