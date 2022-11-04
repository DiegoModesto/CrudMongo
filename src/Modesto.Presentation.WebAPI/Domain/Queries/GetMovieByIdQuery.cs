using MediatR;
using Modesto.Presentation.WebAPI.Models;

namespace Modesto.Presentation.WebAPI.Domain.Queries
{
    public class GetMovieByIdQuery : IRequest<Movie>
    {
        public string Id { get; set; }

        public GetMovieByIdQuery(string id)
            => Id = id;
    }
}
