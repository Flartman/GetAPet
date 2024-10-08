﻿// <auto-generated />
using System;
using System.Collections.Generic;
using GetAPet.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GetAPet.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GetAPet.Domain.Volunteers.Pets.Breed", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("species_id")
                        .HasColumnType("uuid")
                        .HasColumnName("species_id");

                    b.ComplexProperty<Dictionary<string, object>>("Description", "GetAPet.Domain.Volunteers.Pets.Breed.Description#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(2000)
                                .HasColumnType("character varying(2000)")
                                .HasColumnName("desctiption");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Name", "GetAPet.Domain.Volunteers.Pets.Breed.Name#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("name");
                        });

                    b.HasKey("Id")
                        .HasName("pk_breeds");

                    b.HasIndex("species_id")
                        .HasDatabaseName("ix_breeds_species_id");

                    b.ToTable("breeds", (string)null);
                });

            modelBuilder.Entity("GetAPet.Domain.Volunteers.Pets.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateOnly>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<DateOnly>("CreationDate")
                        .HasColumnType("date")
                        .HasColumnName("creation_date");

                    b.Property<double>("Height")
                        .HasColumnType("double precision")
                        .HasColumnName("height");

                    b.Property<bool>("IsNeutered")
                        .HasColumnType("boolean")
                        .HasColumnName("is_neutered");

                    b.Property<bool>("IsVaccinated")
                        .HasColumnType("boolean")
                        .HasColumnName("is_vaccinated");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision")
                        .HasColumnName("weight");

                    b.Property<Guid?>("volunteer_id")
                        .HasColumnType("uuid")
                        .HasColumnName("volunteer_id");

                    b.ComplexProperty<Dictionary<string, object>>("Address", "GetAPet.Domain.Volunteers.Pets.Pet.Address#Address", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("City")
                                .IsRequired()
                                .ValueGeneratedOnUpdateSometimes()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("country");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .ValueGeneratedOnUpdateSometimes()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("country");

                            b1.Property<string>("Region")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("region");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("AnimalDetails", "GetAPet.Domain.Volunteers.Pets.Pet.AnimalDetails#AnimalDetails", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<Guid>("BreedId")
                                .HasColumnType("uuid")
                                .HasColumnName("breed_id");

                            b1.Property<Guid>("SpeciesId")
                                .HasColumnType("uuid")
                                .HasColumnName("species_id");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Coloring", "GetAPet.Domain.Volunteers.Pets.Pet.Coloring#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("coloring");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Description", "GetAPet.Domain.Volunteers.Pets.Pet.Description#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(2000)
                                .HasColumnType("character varying(2000)")
                                .HasColumnName("description");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("HealthInfo", "GetAPet.Domain.Volunteers.Pets.Pet.HealthInfo#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(2000)
                                .HasColumnType("character varying(2000)")
                                .HasColumnName("health_info");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Name", "GetAPet.Domain.Volunteers.Pets.Pet.Name#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("name");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("PhoneNumber", "GetAPet.Domain.Volunteers.Pets.Pet.PhoneNumber#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(11)
                                .HasColumnType("character varying(11)")
                                .HasColumnName("phonenumber");
                        });

                    b.HasKey("Id")
                        .HasName("pk_pets");

                    b.HasIndex("volunteer_id")
                        .HasDatabaseName("ix_pets_volunteer_id");

                    b.ToTable("pets", (string)null);
                });

            modelBuilder.Entity("GetAPet.Domain.Volunteers.Pets.Species", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.ComplexProperty<Dictionary<string, object>>("Description", "GetAPet.Domain.Volunteers.Pets.Species.Description#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(2000)
                                .HasColumnType("character varying(2000)")
                                .HasColumnName("description");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Name", "GetAPet.Domain.Volunteers.Pets.Species.Name#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("name");
                        });

                    b.HasKey("Id")
                        .HasName("pk_species");

                    b.ToTable("species", (string)null);
                });

            modelBuilder.Entity("GetAPet.Domain.Volunteers.Volunteer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("ExperienceInYears")
                        .HasColumnType("integer")
                        .HasColumnName("experience_in_years");

                    b.ComplexProperty<Dictionary<string, object>>("Description", "GetAPet.Domain.Volunteers.Volunteer.Description#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(2000)
                                .HasColumnType("character varying(2000)")
                                .HasColumnName("description");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Email", "GetAPet.Domain.Volunteers.Volunteer.Email#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("email");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("FullName", "GetAPet.Domain.Volunteers.Volunteer.FullName#FullName", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("name");

                            b1.Property<string>("Patronymic")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("patronymic");

                            b1.Property<string>("Surname")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("surname");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("PhoneNumber", "GetAPet.Domain.Volunteers.Volunteer.PhoneNumber#NotEmptyString", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(11)
                                .HasColumnType("character varying(11)")
                                .HasColumnName("phonenumber");
                        });

                    b.HasKey("Id")
                        .HasName("pk_volunteers");

                    b.ToTable("volunteers", (string)null);
                });

            modelBuilder.Entity("GetAPet.Domain.Volunteers.Pets.Breed", b =>
                {
                    b.HasOne("GetAPet.Domain.Volunteers.Pets.Species", null)
                        .WithMany("Breeds")
                        .HasForeignKey("species_id")
                        .HasConstraintName("fk_breeds_species_species_id");
                });

            modelBuilder.Entity("GetAPet.Domain.Volunteers.Pets.Pet", b =>
                {
                    b.HasOne("GetAPet.Domain.Volunteers.Volunteer", null)
                        .WithMany("Pets")
                        .HasForeignKey("volunteer_id")
                        .HasConstraintName("fk_pets_volunteers_volunteer_id");

                    b.OwnsOne("GetAPet.Domain.Volunteers.PaymentDetailsStorage", "PaymentDetailsStorage", b1 =>
                        {
                            b1.Property<Guid>("PetId")
                                .HasColumnType("uuid");

                            b1.HasKey("PetId")
                                .HasName("pk_pets");

                            b1.ToTable("pets");

                            b1.ToJson("payment_details_storage");

                            b1.WithOwner()
                                .HasForeignKey("PetId")
                                .HasConstraintName("fk_pets_pets_pet_id");

                            b1.OwnsMany("GetAPet.Domain.Volunteers.PaymentDetails", "PaymantDetailsList", b2 =>
                                {
                                    b2.Property<Guid>("PaymentDetailsStoragePetId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    b2.Property<string>("Description")
                                        .IsRequired()
                                        .HasMaxLength(2000)
                                        .HasColumnType("character varying(2000)");

                                    b2.Property<string>("Name")
                                        .IsRequired()
                                        .HasMaxLength(100)
                                        .HasColumnType("character varying(100)");

                                    b2.HasKey("PaymentDetailsStoragePetId", "Id");

                                    b2.ToTable("pets");

                                    b2.ToJson("payment_details_storage");

                                    b2.WithOwner()
                                        .HasForeignKey("PaymentDetailsStoragePetId")
                                        .HasConstraintName("fk_pets_pets_payment_details_storage_pet_id");
                                });

                            b1.Navigation("PaymantDetailsList");
                        });

                    b.OwnsOne("GetAPet.Domain.Volunteers.Pets.PetPhotoAlbum", "PhotoAlbum", b1 =>
                        {
                            b1.Property<Guid>("PetId")
                                .HasColumnType("uuid");

                            b1.HasKey("PetId");

                            b1.ToTable("pets");

                            b1.ToJson("photo_album");

                            b1.WithOwner()
                                .HasForeignKey("PetId")
                                .HasConstraintName("fk_pets_pets_id");

                            b1.OwnsMany("GetAPet.Domain.Volunteers.Pets.PetPhoto", "Photos", b2 =>
                                {
                                    b2.Property<Guid>("PetPhotoAlbumPetId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    b2.Property<bool>("IsMain")
                                        .HasColumnType("boolean");

                                    b2.Property<string>("PathToFile")
                                        .IsRequired()
                                        .HasMaxLength(100)
                                        .HasColumnType("character varying(100)");

                                    b2.HasKey("PetPhotoAlbumPetId", "Id");

                                    b2.ToTable("pets");

                                    b2.ToJson("photo_album");

                                    b2.WithOwner()
                                        .HasForeignKey("PetPhotoAlbumPetId")
                                        .HasConstraintName("fk_pets_pets_pet_photo_album_pet_id");
                                });

                            b1.Navigation("Photos");
                        });

                    b.Navigation("PaymentDetailsStorage");

                    b.Navigation("PhotoAlbum");
                });

            modelBuilder.Entity("GetAPet.Domain.Volunteers.Volunteer", b =>
                {
                    b.OwnsOne("GetAPet.Domain.Volunteers.SocialMediaStorage", "SocialMedia", b1 =>
                        {
                            b1.Property<Guid>("VolunteerId")
                                .HasColumnType("uuid");

                            b1.HasKey("VolunteerId");

                            b1.ToTable("volunteers");

                            b1.ToJson("social_media");

                            b1.WithOwner()
                                .HasForeignKey("VolunteerId")
                                .HasConstraintName("fk_volunteers_volunteers_id");

                            b1.OwnsMany("GetAPet.Domain.Volunteers.SocialNetwork", "SocialNetworks", b2 =>
                                {
                                    b2.Property<Guid>("SocialMediaStorageVolunteerId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    b2.Property<string>("Name")
                                        .IsRequired()
                                        .HasMaxLength(100)
                                        .HasColumnType("character varying(100)");

                                    b2.Property<string>("Url")
                                        .IsRequired()
                                        .HasMaxLength(100)
                                        .HasColumnType("character varying(100)");

                                    b2.HasKey("SocialMediaStorageVolunteerId", "Id");

                                    b2.ToTable("volunteers");

                                    b2.ToJson("social_media");

                                    b2.WithOwner()
                                        .HasForeignKey("SocialMediaStorageVolunteerId")
                                        .HasConstraintName("fk_volunteers_volunteers_social_media_storage_volunteer_id");
                                });

                            b1.Navigation("SocialNetworks");
                        });

                    b.OwnsOne("GetAPet.Domain.Volunteers.PaymentDetailsStorage", "PaymentDetailsStorage", b1 =>
                        {
                            b1.Property<Guid>("VolunteerId")
                                .HasColumnType("uuid");

                            b1.HasKey("VolunteerId");

                            b1.ToTable("volunteers");

                            b1.ToJson("payment_details_storage");

                            b1.WithOwner()
                                .HasForeignKey("VolunteerId")
                                .HasConstraintName("fk_volunteers_volunteers_id");

                            b1.OwnsMany("GetAPet.Domain.Volunteers.PaymentDetails", "PaymantDetailsList", b2 =>
                                {
                                    b2.Property<Guid>("PaymentDetailsStorageVolunteerId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    b2.Property<string>("Description")
                                        .IsRequired()
                                        .HasMaxLength(2000)
                                        .HasColumnType("character varying(2000)");

                                    b2.Property<string>("Name")
                                        .IsRequired()
                                        .HasMaxLength(100)
                                        .HasColumnType("character varying(100)");

                                    b2.HasKey("PaymentDetailsStorageVolunteerId", "Id");

                                    b2.ToTable("volunteers");

                                    b2.ToJson("payment_details_storage");

                                    b2.WithOwner()
                                        .HasForeignKey("PaymentDetailsStorageVolunteerId")
                                        .HasConstraintName("fk_volunteers_volunteers_payment_details_storage_volunteer_id");
                                });

                            b1.Navigation("PaymantDetailsList");
                        });

                    b.Navigation("PaymentDetailsStorage");

                    b.Navigation("SocialMedia");
                });

            modelBuilder.Entity("GetAPet.Domain.Volunteers.Pets.Species", b =>
                {
                    b.Navigation("Breeds");
                });

            modelBuilder.Entity("GetAPet.Domain.Volunteers.Volunteer", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
