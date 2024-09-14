using GetAPet.Domain.Shared;
using GetAPet.Domain.Volunteers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetAPet.Infrastructure.Configurations
{
    public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.ToTable("volunteers");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id)
                .IsRequired();

            builder.Property(v => v.FullName)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            builder.Property(v => v.Email)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            builder.Property(v => v.Description)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);

            builder.Property(v => v.ExperienceInYears)
                .IsRequired();

            builder.Property(v => v.PhoneNumber)
                .IsRequired()
                .HasMaxLength(Constants.MAX_PHONENUMBER_LENGTH);

            builder.HasMany(v => v.SocialMedia)
                .WithOne()
                .HasForeignKey("volunteer_id");

            builder.HasMany(v => v.PaymantDetailsList)
                .WithOne()
                .HasForeignKey("volunteer_id");

            builder.HasMany(v => v.Pets);


        }
    }
}
