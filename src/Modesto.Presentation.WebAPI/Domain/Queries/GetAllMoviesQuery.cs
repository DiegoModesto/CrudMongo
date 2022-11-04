using MediatR;
using Modesto.Presentation.WebAPI.Models;

namespace Modesto.Presentation.WebAPI.Domain.Queries
{
    public class GetAllMoviesQuery : IRequest<List<Movie>>
    {
    }
}
