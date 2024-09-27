﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Vet_Management_Tool.Migrations
{
    [DbContext(typeof(VetDbContext))]
    [Migration("20240927135233_InitialTest3.0")]
    partial class InitialTest30
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Clinic", b =>
                {
                    b.Property<int>("ClinicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ClinicId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClinicName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("ClinicId");

                    b.ToTable("Clinics");

                    b.HasData(
                        new
                        {
                            ClinicId = 1,
                            Address = "6253 Park Avenue",
                            ClinicName = "Barry Bonds Pet Care",
                            PhoneNum = "5615366410"
                        },
                        new
                        {
                            ClinicId = 2,
                            Address = "1800 Martin Luther King Blvd",
                            ClinicName = "Dr.G's Clinic for Critters",
                            PhoneNum = "9542638957"
                        },
                        new
                        {
                            ClinicId = 3,
                            Address = "96 Carlyle Rd",
                            ClinicName = "Unlucky Pet Health Services",
                            PhoneNum = "7623916578"
                        },
                        new
                        {
                            ClinicId = 4,
                            Address = "8971 Lake Shore Dr",
                            ClinicName = "South Side Veterinarian Center",
                            PhoneNum = "9021013365"
                        },
                        new
                        {
                            ClinicId = 5,
                            Address = "9856 San Marino Circle",
                            ClinicName = "Adler Animal Hospital",
                            PhoneNum = "3056650819"
                        });
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ClinicId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("DOB")
                        .HasColumnType("date");

                    b.Property<string>("EmployeePhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Salary")
                        .HasColumnType("integer");

                    b.HasKey("EmployeeId");

                    b.HasIndex("ClinicId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Address = "56 Kimberly Estates",
                            ClinicId = 1,
                            DOB = new DateOnly(1998, 3, 28),
                            EmployeePhone = "5506959506",
                            FirstName = "Benjamin",
                            LastName = "Chodry",
                            Position = "Head Veterinarian",
                            Salary = 112000
                        },
                        new
                        {
                            EmployeeId = 2,
                            Address = "001 Holly Grove Street",
                            ClinicId = 2,
                            DOB = new DateOnly(1982, 9, 27),
                            EmployeePhone = "4109505899",
                            FirstName = "Dwayne",
                            LastName = "Carter",
                            Position = "Head Veterinarian",
                            Salary = 112000
                        },
                        new
                        {
                            EmployeeId = 3,
                            Address = "22 Melrose Point",
                            ClinicId = 3,
                            DOB = new DateOnly(2002, 11, 8),
                            EmployeePhone = "5286934578",
                            FirstName = "Amy",
                            LastName = "Greenberg",
                            Position = "Head Veterinarian",
                            Salary = 112000
                        },
                        new
                        {
                            EmployeeId = 4,
                            Address = "783 Palmetto Park Rd",
                            ClinicId = 4,
                            DOB = new DateOnly(1976, 6, 15),
                            EmployeePhone = "8923672103",
                            FirstName = "Mike",
                            LastName = "Chambers",
                            Position = "Head Veterinarian",
                            Salary = 112000
                        },
                        new
                        {
                            EmployeeId = 5,
                            Address = "21 Scranton Blvd",
                            ClinicId = 5,
                            DOB = new DateOnly(1963, 4, 30),
                            EmployeePhone = "1569876521",
                            FirstName = "Jan",
                            LastName = "Levinson",
                            Position = "Head Veterinarian",
                            Salary = 112000
                        },
                        new
                        {
                            EmployeeId = 6,
                            Address = "123 Maple Street",
                            ClinicId = 1,
                            DOB = new DateOnly(1990, 7, 12),
                            EmployeePhone = "3056781234",
                            FirstName = "Laura",
                            LastName = "Smith",
                            Position = "Office Manager",
                            Salary = 80000
                        },
                        new
                        {
                            EmployeeId = 7,
                            Address = "456 Oak Avenue",
                            ClinicId = 2,
                            DOB = new DateOnly(1985, 2, 20),
                            EmployeePhone = "4071234567",
                            FirstName = "James",
                            LastName = "Johnson",
                            Position = "Office Manager",
                            Salary = 80000
                        },
                        new
                        {
                            EmployeeId = 8,
                            Address = "789 Pine Road",
                            ClinicId = 3,
                            DOB = new DateOnly(1995, 5, 15),
                            EmployeePhone = "5612345678",
                            FirstName = "Emily",
                            LastName = "Davis",
                            Position = "Office Manager",
                            Salary = 80000
                        },
                        new
                        {
                            EmployeeId = 9,
                            Address = "321 Birch Lane",
                            ClinicId = 4,
                            DOB = new DateOnly(1978, 11, 30),
                            EmployeePhone = "9548765432",
                            FirstName = "Michael",
                            LastName = "Brown",
                            Position = "Office Manager",
                            Salary = 80000
                        },
                        new
                        {
                            EmployeeId = 10,
                            Address = "654 Cedar Court",
                            ClinicId = 5,
                            DOB = new DateOnly(1988, 8, 25),
                            EmployeePhone = "7863456789",
                            FirstName = "Sarah",
                            LastName = "Wilson",
                            Position = "Office Manager",
                            Salary = 80000
                        });
                });

            modelBuilder.Entity("Examination", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ExamId"));

                    b.Property<string>("ActionTaken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ChiefComplaint")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ClinicId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int?>("PetId")
                        .HasColumnType("integer");

                    b.HasKey("ExamId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PetId");

                    b.ToTable("Examinations");

                    b.HasData(
                        new
                        {
                            ExamId = 1,
                            ActionTaken = "Metal screw inserted",
                            ChiefComplaint = "Broken Bone",
                            ClinicId = 1,
                            Date = new DateOnly(2024, 3, 20),
                            EmployeeId = 1,
                            PetId = 1
                        },
                        new
                        {
                            ExamId = 2,
                            ActionTaken = "Surgery",
                            ChiefComplaint = "Broken Bone",
                            ClinicId = 2,
                            Date = new DateOnly(2023, 3, 20),
                            EmployeeId = 2,
                            PetId = 2
                        },
                        new
                        {
                            ExamId = 3,
                            ActionTaken = "Metal plate inserted",
                            ChiefComplaint = "Broken Bone",
                            ClinicId = 3,
                            Date = new DateOnly(2022, 11, 30),
                            EmployeeId = 3,
                            PetId = 3
                        },
                        new
                        {
                            ExamId = 4,
                            ActionTaken = "Prescribed antibiotics",
                            ChiefComplaint = "Avian Flu",
                            ClinicId = 4,
                            Date = new DateOnly(2021, 11, 18),
                            EmployeeId = 4,
                            PetId = 4
                        },
                        new
                        {
                            ExamId = 5,
                            ActionTaken = "De-worming injection given",
                            ChiefComplaint = "Parasitic infection",
                            ClinicId = 5,
                            Date = new DateOnly(2024, 8, 30),
                            EmployeeId = 5,
                            PetId = 5
                        });
                });

            modelBuilder.Entity("Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OwnerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ClinicId")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OwnerPhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("OwnerId");

                    b.HasIndex("ClinicId");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            OwnerId = 1,
                            Address = "52 Nawfside Rd",
                            ClinicId = 1,
                            FirstName = "Kirsnick",
                            LastName = "Ball",
                            OwnerPhone = "9875623358"
                        },
                        new
                        {
                            OwnerId = 2,
                            Address = "6842 Hillside Lane",
                            ClinicId = 2,
                            FirstName = "Jon",
                            LastName = "Lun",
                            OwnerPhone = "5552106838"
                        },
                        new
                        {
                            OwnerId = 3,
                            Address = "2318 Mountain Hill Drive",
                            ClinicId = 3,
                            FirstName = "Alena",
                            LastName = "Gleeman",
                            OwnerPhone = "3736912387"
                        },
                        new
                        {
                            OwnerId = 4,
                            Address = "64 Cherry Red Rd",
                            ClinicId = 4,
                            FirstName = "Rashida",
                            LastName = "Crowdstrike",
                            OwnerPhone = "1475623251"
                        },
                        new
                        {
                            OwnerId = 5,
                            Address = "1165 Oceanic Plaza",
                            ClinicId = 5,
                            FirstName = "Miguel",
                            LastName = "Gomez",
                            OwnerPhone = "2326587769"
                        });
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PetId"));

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ClinicId")
                        .HasColumnType("integer");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DOB")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PetId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            PetId = 1,
                            Breed = "Shitzu",
                            ClinicId = 1,
                            Color = "White",
                            DOB = new DateOnly(2016, 3, 14),
                            Name = "Rex",
                            OwnerId = 1,
                            Species = "Dog"
                        },
                        new
                        {
                            PetId = 2,
                            Breed = "Dalmation",
                            ClinicId = 2,
                            Color = "White",
                            DOB = new DateOnly(2022, 2, 10),
                            Name = "Domino",
                            OwnerId = 2,
                            Species = "Dog"
                        },
                        new
                        {
                            PetId = 3,
                            Breed = "Macaw",
                            ClinicId = 3,
                            Color = "Green",
                            DOB = new DateOnly(2018, 10, 6),
                            Name = "Timothy",
                            OwnerId = 3,
                            Species = "Parrot"
                        },
                        new
                        {
                            PetId = 4,
                            Breed = "Shorthair",
                            ClinicId = 4,
                            Color = "Grey",
                            DOB = new DateOnly(2017, 1, 19),
                            Name = "Cristoff",
                            OwnerId = 4,
                            Species = "Cat"
                        },
                        new
                        {
                            PetId = 5,
                            Breed = "Mamba",
                            ClinicId = 5,
                            Color = "Black",
                            DOB = new DateOnly(2019, 5, 26),
                            Name = "Kobe",
                            OwnerId = 5,
                            Species = "Snake"
                        });
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.HasOne("Clinic", "Clinic")
                        .WithMany("Employees")
                        .HasForeignKey("ClinicId");

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("Examination", b =>
                {
                    b.HasOne("Clinic", "Clinic")
                        .WithMany("Examinations")
                        .HasForeignKey("ClinicId");

                    b.HasOne("Employee", "Employee")
                        .WithMany("Examinations")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Pet", "Pet")
                        .WithMany("Examinations")
                        .HasForeignKey("PetId");

                    b.Navigation("Clinic");

                    b.Navigation("Employee");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("Owner", b =>
                {
                    b.HasOne("Clinic", "Clinic")
                        .WithMany()
                        .HasForeignKey("ClinicId");

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.HasOne("Clinic", "Clinic")
                        .WithMany("Pets")
                        .HasForeignKey("ClinicId");

                    b.HasOne("Owner", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Clinic");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Clinic", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Examinations");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Navigation("Examinations");
                });

            modelBuilder.Entity("Owner", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.Navigation("Examinations");
                });
#pragma warning restore 612, 618
        }
    }
}
