using MediatR;
using Modesto.Presentation.WebAPI.Domain.Queries;
using Modesto.Presentation.WebAPI.Models;
using Modesto.Presentation.WebAPI.Services;

namespace Modesto.Presentation.WebAPI.Domain.Handlers
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, Movie>
    {
        private readonly MovieService _service;

        public GetMovieByIdHandler(MovieService service) => _service = service;

        public async Task<Movie> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
            =>  await _service.GetAsync(request.Id);
    }
}
