using MediatR;
using Modesto.Presentation.WebAPI.Domain.Commands;
using Modesto.Presentation.WebAPI.Models;
using Modesto.Presentation.WebAPI.Services;

namespace Modesto.Presentation.WebAPI.Domain.Handlers
{
    public class UpdateMovieHandler : IRequestHandler<UpdateMovieCommand, Movie>
    {
        private readonly MovieService _service;

        public UpdateMovieHandler(MovieService service) => _service = service;

        public async Task<Movie> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {

            var movie = await _service.GetAsync(request.Id);

            if (movie is null)
                return null;

            movie.Title = request.Title;
            movie.Plot = request.Plot;
            movie.Rating = request.Rating;
            movie.Genre = request.Genre;

            await _service.UpdateAsync(request.Id, movie);

            return movie;
        }
    }
}
