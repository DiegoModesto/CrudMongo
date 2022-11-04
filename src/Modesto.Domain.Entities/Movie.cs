using Modesto.Domain.Entities.Abstract;

namespace Modesto.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Plot { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
    }
}
