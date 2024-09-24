using GetAPet.Domain.Shared;
using GetAPet.Domain.Volunteers;
using GetAPet.Domain.Volunteers.Pets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetAPet.Infrastructure.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("pets");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    value => PetId.Create(value));

            builder.ComplexProperty(pet => pet.Name, sb =>
            {
                sb.Property(nes => nes.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH)
                .HasColumnName("name");
            });

            builder.ComplexProperty(pet => pet.AnimalDetails, pb =>
            {
                pb.Property(ad => ad.SpeciesId)
                    .HasConversion(
                        id => id.Value, 
                        value => SpeciesId.Create(value))
                    .IsRequired()
                    .HasColumnName("species_id");

                pb.Property(ad => ad.BreedId)
                    .HasConversion(
                            id => id.Value,
                            value => BreedId.Create(value))
                    .IsRequired()
                    .HasColumnName("breed_id");
            });

            builder.ComplexProperty(pet => pet.Description, sb =>
            {
                sb.Property(nes => nes.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LONG_TEXT_LENGTH)
                .HasColumnName("description");
            });

            builder.ComplexProperty(pet => pet.Coloring, sb =>
            {
                sb.Property(nes => nes.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH)
                .HasColumnName("coloring");
            });

            builder.ComplexProperty(pet => pet.HealthInfo, sb =>
            {
                sb.Property(nes => nes.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LONG_TEXT_LENGTH)
                .HasColumnName("health_info");
            });
            
            builder.ComplexProperty(p => p.Address, pb =>
            {
                pb.ComplexProperty(address => address.Country, sb =>
                {
                    sb.Property(nes => nes.Value)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH)
                    .HasColumnName("country");
                });

                pb.ComplexProperty(address => address.Region, sb =>
                {
                    sb.Property(nes => nes.Value)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH)
                    .HasColumnName("region");
                });

                pb.ComplexProperty(address => address.City, sb =>
                {
                    sb.Property(nes => nes.Value)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH)
                    .HasColumnName("city");
                });
            });

            builder.Property(p => p.Weight)
                .IsRequired();

            builder.Property(p => p.Height)
                .IsRequired();


            builder.ComplexProperty(pet => pet.PhoneNumber, sb =>
            {
                sb.Property(nes => nes.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_PHONENUMBER_LENGTH)
                .HasColumnName("phonenumber");
            });


            builder.Property(p => p.IsNeutered)
                .IsRequired();

            builder.Property(p => p.Birthdate)
                .IsRequired();

            builder.Property(p => p.IsVaccinated)
                .IsRequired();

            builder.Property(p => p.Status)
                .IsRequired();

            builder.OwnsOne(p => p.PaymentDetailsStorage, pb =>
            {
                pb.ToJson();

                pb.OwnsMany(pds => pds.PaymantDetailsList, pdb =>
                {
                    pdb.Property(pd => pd.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH);

                    pdb.Property(pd => pd.Description)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LONG_TEXT_LENGTH);
                });
            });


            builder.Property(p => p.CreationDate)
                .IsRequired();

            builder.OwnsOne(p => p.PhotoAlbum, pb =>
            {
                pb.ToJson();

                pb.OwnsMany(pa => pa.Photos, pab =>
                {
                    pab.Property(ph => ph.IsMain)
                    .IsRequired();

                    pab.Property(ph => ph.PathToFile)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH);
                });
            });
        }
    }
}