using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modesto.Domain.Entities;

namespace Modesto.Infra.EntityFramework.Configuration
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.FirstName)
                .HasMaxLength(60)
                .IsRequired();

            builder
                .Property(x => x.LastName)
                .HasMaxLength(60)
                .IsRequired();

            builder
                .Property(x => x.BirthDate)
                .IsRequired();
        }
    }
}
