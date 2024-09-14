using GetAPet.Domain.Pets;
using GetAPet.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetAPet.Infrastructure.Configurations
{
    internal class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("pets");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            builder.Property(p => p.Species)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);

            builder.Property(p => p.Breed)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            builder.Property(p => p.Coloring)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            builder.Property(p => p.HealthInfo)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);

            builder.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            builder.Property(p => p.Weight)
                .IsRequired();

            builder.Property(p => p.Height)
                .IsRequired();

            builder.Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(Constants.MAX_PHONENUMBER_LENGTH);

            builder.Property(p => p.IsNeutered)
                .IsRequired();

            builder.Property(p => p.Birthdate)
                .IsRequired();

            builder.Property(p => p.IsVaccinated)
                .IsRequired();

            builder.Property(p => p.Status)
                .IsRequired();

            builder.HasMany(p => p.PaymantDetailsList)
                .WithOne()
                .HasForeignKey("pet_id")
                .IsRequired();

            builder.Property(p => p.CreationDate)
                .IsRequired();

            builder.HasMany(p => p.Photos)
                .WithOne()
                .HasForeignKey("pet_id")
                .IsRequired();
        }
    }
}