using MediatR;
using Modesto.Presentation.WebAPI.Domain.Commands;
using Modesto.Presentation.WebAPI.Models;
using Modesto.Presentation.WebAPI.Services;

namespace Modesto.Presentation.WebAPI.Domain.Handlers
{
    public class CreateMovieHandler : IRequestHandler<CreateMovieCommand, Movie>
    {
        private readonly MovieService _service;

        public CreateMovieHandler(MovieService service) => _service = service;

        public async Task<Movie> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            //Para ser rápido, não vou fazer verificações sobre existência prévia
            //ou possibilidade por gênero e afins. Apenas insersão
            var newMovie = new Movie()
            {
                Genre = request.Genre,
                Plot = request.Plot,
                Rating = request.Rating,
                Title = request.Title
            };

            await _service.CreateAsync(newMovie);

            return newMovie;
        }
    }
}
