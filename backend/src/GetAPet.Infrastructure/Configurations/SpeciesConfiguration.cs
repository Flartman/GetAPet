using GetAPet.Domain.Shared;
using GetAPet.Domain.Volunteers.Pets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GetAPet.Infrastructure.Configurations
{
    public class SpeciesConfiguration : IEntityTypeConfiguration<Species>
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            builder.ToTable("species");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .IsRequired()
                .HasConversion(
                    Id => Id.Value, 
                    value => SpeciesId.Create(value));

            builder.ComplexProperty(s => s.Name, pb =>
            {
                pb.Property(nes => nes.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH)
                .HasColumnName("name");
            });

            builder.ComplexProperty(s => s.Description, pb =>
            {
                pb.Property(nes => nes.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LONG_TEXT_LENGTH)
                .HasColumnName("description");
            });

            builder.HasMany(s => s.Breeds)
                .WithOne()
                .HasForeignKey("species_id");
        }
    }
}
