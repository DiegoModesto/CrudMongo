using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MediatR;
using Modesto.Presentation.WebAPI.Models;

namespace Modesto.Presentation.WebAPI.Domain.Commands
{
    public class CreateMovieCommand : IRequest<Movie>
    {
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Plot { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
    }
}
