using MediatR;
using Modesto.Presentation.WebAPI.Models;

namespace Modesto.Presentation.WebAPI.Domain.Commands
{
    public class DeleteMovieCommand : IRequest<bool>
    {
        public string? Id { get; set; } = null;

        public DeleteMovieCommand(string? id)
            => Id = id;
    }
}
