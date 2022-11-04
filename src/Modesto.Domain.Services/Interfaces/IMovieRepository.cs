using Modesto.Domain.Entities;

namespace Modesto.Domain.Services.Interfaces
{
    public interface IMovieRepository
    {
        Task Add(Movie movie);
        Task Get(Guid id);
    }
}
