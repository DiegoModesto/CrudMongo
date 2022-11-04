using Modesto.Domain.Entities;
using Modesto.Domain.Services.Interfaces;

namespace Modesto.Infra.EntityFramework.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private ModestoContext _ctx { get; set; }
        public MovieRepository(ModestoContext ctx)
        {
            _ctx = ctx;
        }

        public Task Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
