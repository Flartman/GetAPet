﻿using GetAPet.Domain.Shared;
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
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    value => VolunteerId.Create(value));

            builder.OwnsOne(v => v.FullName, vb =>
            {
                vb.Property(fn => fn.Surname)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
                vb.Property(fn => fn.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
                vb.Property(fn => fn.Patronymic)
                    .IsRequired(false)
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
            });

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

            builder.OwnsOne(v => v.SocialMedia, vb =>
            {
                vb.ToJson();

                vb.OwnsMany(sms => sms.SocialNetworks, smb =>
                {
                    smb.Property(sn => sn.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                    smb.Property(sn => sn.URL)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
                });

            });

            builder.OwnsOne(v => v.PaymentDetailsStorage, vb =>
            {
                vb.ToJson();

                vb.OwnsMany(pds => pds.PaymantDetailsList, pdb =>
                {
                    pdb.Property(pd => pd.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                    pdb.Property(pd => pd.Description)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);
                });
            });

            builder.HasMany(v => v.Pets)
                .WithOne()
                .HasForeignKey("volunteer_id");


        }
    }
}
