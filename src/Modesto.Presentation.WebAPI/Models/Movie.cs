using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Modesto.Presentation.WebAPI.Models
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Plot { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
    }
}
