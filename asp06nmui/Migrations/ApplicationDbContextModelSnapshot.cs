﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp06nmui.Data;

#nullable disable

namespace asp06nmui.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("asp06nmui.Model.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"), 1L, 1);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            Firstname = "Tom",
                            Lastname = "Cruise"
                        },
                        new
                        {
                            ArtistId = 2,
                            Firstname = "Val",
                            Lastname = "Kilmer"
                        });
                });

            modelBuilder.Entity("asp06nmui.Model.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Title = "Top Gun"
                        },
                        new
                        {
                            MovieId = 2,
                            Title = "Top Gun: Maverick"
                        });
                });

            modelBuilder.Entity("asp06nmui.Model.Role", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MovieId", "ArtistId", "Name");

                    b.HasIndex("ArtistId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ArtistId = 1,
                            Name = "Maverick"
                        });
                });

            modelBuilder.Entity("asp06nmui.Model.Role", b =>
                {
                    b.HasOne("asp06nmui.Model.Artist", "Artist")
                        .WithMany("Roles")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asp06nmui.Model.Movie", "Movie")
                        .WithMany("Roles")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("asp06nmui.Model.Artist", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("asp06nmui.Model.Movie", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}