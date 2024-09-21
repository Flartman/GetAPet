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

            builder.ComplexProperty(p => p.Address, pb =>
            {
                pb.Property(address => address.Country)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                pb.Property(address => address.Region)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                pb.Property(address => address.City)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                pb.Property(address => address.Street)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                pb.Property(address => address.HouseNumber)
                    .IsRequired();

                pb.Property(address => address.EntranceNumber)
                    .IsRequired();

                pb.Property(address => address.FloorNumber)
                    .IsRequired();

                pb.Property(address => address.ApartmentNumber)
                    .IsRequired();
            });

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

            builder.OwnsOne(p => p.PaymentDetailsStorage, pb =>
            {
                pb.ToJson();

                pb.OwnsMany(pds => pds.PaymantDetailsList, pdb =>
                {
                    pdb.Property(pd => pd.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                    pdb.Property(pd => pd.Description)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);
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
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
                });
            });
        }
    }
}