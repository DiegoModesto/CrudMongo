using Microsoft.EntityFrameworkCore;
using Modesto.Domain.Entities;

namespace Modesto.Infra.EntityFramework
{
    public class ModestoContext : DbContext
    {
        public ModestoContext(DbContextOptions<ModestoContext> opt) : base(opt)
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
