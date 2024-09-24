using GetAPet.Domain.Shared;
using GetAPet.Domain.Volunteers.Pets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetAPet.Infrastructure.Configurations
{
    public class BreedConfiguration : IEntityTypeConfiguration<Breed>
    {
        public void Configure(EntityTypeBuilder<Breed> builder)
        {
            builder.ToTable("breeds");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .IsRequired()
                .HasConversion(
                    id => id.Value, 
                    value => BreedId.Create(value));

            builder.ComplexProperty(b => b.Name, pb =>
            {
                pb.Property(n => n.Value)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH)
                    .HasColumnName("name");
            });

            builder.ComplexProperty(b => b.Description, pb =>
            {
                pb.Property(d => d.Value)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LONG_TEXT_LENGTH)
                    .HasColumnName("desctiption");
            });
        }
    }
}
