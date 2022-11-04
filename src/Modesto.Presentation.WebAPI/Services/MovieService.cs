using Microsoft.Extensions.Options;
using Modesto.Presentation.WebAPI.Models;
using MongoDB.Driver;

namespace Modesto.Presentation.WebAPI.Services
{
    public class MovieService
    {
        //Será usado como central de repositório, basicamente será
        //mais ágil fazer assim do que um UoW ou RepoPatt, pois é apenas um CRUD de exemplo
        private readonly IMongoCollection<Movie> _movieCollection;

        public MovieService(IOptions<MovieStoreDatabaseSettings> settings)
        {
            var mongoClient = new MongoClient(settings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(settings.Value.DatabaseName);

            _movieCollection = mongoDatabase.GetCollection<Movie>(settings.Value.CollectionName);
        }

        public async Task<List<Movie>> GetAsync() 
            => await _movieCollection.Find(_ => true).ToListAsync();
        public async Task<Movie?> GetAsync(string id) =>
        await _movieCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Movie newMovie) =>
            await _movieCollection.InsertOneAsync(newMovie);

        public async Task UpdateAsync(string id, Movie updatedMovie) =>
            await _movieCollection.ReplaceOneAsync(x => x.Id == id, updatedMovie);

        public async Task RemoveAsync(string id) =>
            await _movieCollection.DeleteOneAsync(x => x.Id == id);
    }
}
