namespace Modesto.Domain.Entities.Abstract
{
    public abstract class BaseEntity : IdEntity
    {
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public bool IsActive { get; set; }
    }
}
