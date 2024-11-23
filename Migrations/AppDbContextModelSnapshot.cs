﻿// <auto-generated />
using System;
using LibraryOfVermundi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryOfVermundi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LibraryOfVermundi.Models.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("SignUpDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AppUserId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("LibraryOfVermundi.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<int?>("EntryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CategoryId");

                    b.HasIndex("EntryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LibraryOfVermundi.Models.Entry", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int?>("ContributorAppUserId")
                        .HasColumnType("int");

                    b.Property<string>("RawContent")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("EntryId");

                    b.HasIndex("ContributorAppUserId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("LibraryOfVermundi.Models.Category", b =>
                {
                    b.HasOne("LibraryOfVermundi.Models.Entry", null)
                        .WithMany("Category")
                        .HasForeignKey("EntryId");
                });

            modelBuilder.Entity("LibraryOfVermundi.Models.Entry", b =>
                {
                    b.HasOne("LibraryOfVermundi.Models.AppUser", "Contributor")
                        .WithMany()
                        .HasForeignKey("ContributorAppUserId");

                    b.Navigation("Contributor");
                });

            modelBuilder.Entity("LibraryOfVermundi.Models.Entry", b =>
                {
                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
