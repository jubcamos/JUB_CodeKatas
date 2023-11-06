﻿// <auto-generated />
using System;
using EfCoreResults.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreResult.Migrations
{
    [DbContext(typeof(GameLibraryContext))]
    [Migration("20231106105141_InitialGameLibraryDB")]
    partial class InitialGameLibraryDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCoreResults.Models.DeveloperStudio", b =>
                {
                    b.Property<int>("DeveloperStudioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeveloperStudioId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeveloperStudioId");

                    b.ToTable("DeveloperStudios");
                });

            modelBuilder.Entity("EfCoreResults.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeveloperStudioId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("RealeaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("GameId");

                    b.HasIndex("DeveloperStudioId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("EfCoreResults.Models.Game", b =>
                {
                    b.HasOne("EfCoreResults.Models.DeveloperStudio", "developer")
                        .WithMany("DevelopedGames")
                        .HasForeignKey("DeveloperStudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("developer");
                });

            modelBuilder.Entity("EfCoreResults.Models.DeveloperStudio", b =>
                {
                    b.Navigation("DevelopedGames");
                });
#pragma warning restore 612, 618
        }
    }
}
