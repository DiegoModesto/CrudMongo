using Modesto.Domain.Entities.Abstract;

namespace Modesto.Domain.Entities
{
    public class Person : BaseEntity
    {
        public Guid Id { get; set; }
        public long Code { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }
    }
}