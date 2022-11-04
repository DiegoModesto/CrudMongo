using MediatR;
using Modesto.Presentation.WebAPI.Domain.Queries;
using Modesto.Presentation.WebAPI.Models;
using Modesto.Presentation.WebAPI.Services;

namespace Modesto.Presentation.WebAPI.Domain.Handlers
{
    public class GetAllMoviesHandler : IRequestHandler<GetAllMoviesQuery, List<Movie>>
    {
        private readonly MovieService _service;

        public GetAllMoviesHandler(MovieService service) => _service = service;

        public async Task<List<Movie>> Handle(GetAllMoviesQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetAsync();
        }
    }
}
