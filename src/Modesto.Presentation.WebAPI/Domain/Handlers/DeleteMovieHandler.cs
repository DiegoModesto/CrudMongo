using MediatR;
using Modesto.Presentation.WebAPI.Domain.Commands;
using Modesto.Presentation.WebAPI.Services;

namespace Modesto.Presentation.WebAPI.Domain.Handlers
{
    public class DeleteMovieHandler : IRequestHandler<DeleteMovieCommand, bool>
    {
        private readonly MovieService _service;

        public DeleteMovieHandler(MovieService service) => _service = service;

        public async Task<bool> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = await _service.GetAsync(request.Id);
            if (movie == null) return false;

            await _service.RemoveAsync(request.Id);
            return true;
        }
    }
}
