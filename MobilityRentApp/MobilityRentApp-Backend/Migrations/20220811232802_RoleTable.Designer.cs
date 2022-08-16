﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobilityRentApp_Backend.Data;

#nullable disable

namespace MobilityRentApp_Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220811232802_RoleTable")]
    partial class RoleTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MobilityRentApp_Backend.Model.Entities.Mobility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MobilityKindId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RentEnrollmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MobilityKindId");

                    b.ToTable("Mobilities");
                });

            modelBuilder.Entity("MobilityRentApp_Backend.Model.Entities.MobilityKind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("RentFee")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MobilityKinds");
                });

            modelBuilder.Entity("MobilityRentApp_Backend.Model.Entities.RentEnrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MobilityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MobilityId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("RentEnrollments");
                });

            modelBuilder.Entity("MobilityRentApp_Backend.Model.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MobilityRentApp_Backend.Model.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MobilityRentApp_Backend.Model.Entities.Mobility", b =>
                {
                    b.HasOne("MobilityRentApp_Backend.Model.Entities.MobilityKind", "Kind")
                        .WithMany()
                        .HasForeignKey("MobilityKindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kind");
                });

            modelBuilder.Entity("MobilityRentApp_Backend.Model.Entities.RentEnrollment", b =>
                {
                    b.HasOne("MobilityRentApp_Backend.Model.Entities.Mobility", "Mobility")
                        .WithOne("RentEnrollment")
                        .HasForeignKey("MobilityRentApp_Backend.Model.Entities.RentEnrollment", "MobilityId");

                    b.HasOne("MobilityRentApp_Backend.Model.Entities.User", "Renter")
                        .WithMany("RentEnrollments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mobility");

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("MobilityRentApp_Backend.Model.Entities.Mobility", b =>
                {
                    b.Navigation("RentEnrollment")
                        .IsRequired();
                });

            modelBuilder.Entity("MobilityRentApp_Backend.Model.Entities.User", b =>
                {
                    b.Navigation("RentEnrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
