﻿// <auto-generated />
using System;
using Exosky.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exosky.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240924173640_ChatHub")]
    partial class ChatHub
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Exosky.Models.ChatMessage", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"));

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("Exosky.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SharedSkyMapId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SharedSkyMapId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Exosky.Models.Constellation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SkyMapId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkyMapId");

                    b.ToTable("Constellations");
                });

            modelBuilder.Entity("Exosky.Models.Exoplanet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DistanceFromEarth")
                        .HasColumnType("float");

                    b.Property<string>("HostStar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrbitalPeriod")
                        .HasColumnType("float");

                    b.Property<double>("Radius")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Exoplanets");
                });

            modelBuilder.Entity("Exosky.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("LikeDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SharedSkyMapId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SharedSkyMapId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Exosky.Models.SharedSkyMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("SharedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SkyMapId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkyMapId");

                    b.HasIndex("UserId");

                    b.ToTable("SharedSkyMaps");
                });

            modelBuilder.Entity("Exosky.Models.SkyMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExoplanetId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ObservationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExoplanetId");

                    b.HasIndex("UserId");

                    b.ToTable("SkyMaps");
                });

            modelBuilder.Entity("Exosky.Models.Star", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("ApparentMagnitude")
                        .HasColumnType("float");

                    b.Property<int?>("ConstellationId")
                        .HasColumnType("int");

                    b.Property<double>("Declination")
                        .HasColumnType("float");

                    b.Property<double>("DistanceFromEarth")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RightAscension")
                        .HasColumnType("float");

                    b.Property<int?>("SkyMapId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConstellationId");

                    b.HasIndex("SkyMapId");

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("Exosky.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BarthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Exosky.Models.Comment", b =>
                {
                    b.HasOne("Exosky.Models.SharedSkyMap", null)
                        .WithMany("Comments")
                        .HasForeignKey("SharedSkyMapId");

                    b.HasOne("Exosky.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Exosky.Models.Constellation", b =>
                {
                    b.HasOne("Exosky.Models.SkyMap", null)
                        .WithMany("Constellations")
                        .HasForeignKey("SkyMapId");
                });

            modelBuilder.Entity("Exosky.Models.Like", b =>
                {
                    b.HasOne("Exosky.Models.SharedSkyMap", null)
                        .WithMany("Likes")
                        .HasForeignKey("SharedSkyMapId");

                    b.HasOne("Exosky.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Exosky.Models.SharedSkyMap", b =>
                {
                    b.HasOne("Exosky.Models.SkyMap", "SkyMap")
                        .WithMany()
                        .HasForeignKey("SkyMapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exosky.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SkyMap");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Exosky.Models.SkyMap", b =>
                {
                    b.HasOne("Exosky.Models.Exoplanet", "Exoplanet")
                        .WithMany()
                        .HasForeignKey("ExoplanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exosky.Models.User", null)
                        .WithMany("SavedSkyMaps")
                        .HasForeignKey("UserId");

                    b.Navigation("Exoplanet");
                });

            modelBuilder.Entity("Exosky.Models.Star", b =>
                {
                    b.HasOne("Exosky.Models.Constellation", null)
                        .WithMany("Stars")
                        .HasForeignKey("ConstellationId");

                    b.HasOne("Exosky.Models.SkyMap", null)
                        .WithMany("Stars")
                        .HasForeignKey("SkyMapId");
                });

            modelBuilder.Entity("Exosky.Models.Constellation", b =>
                {
                    b.Navigation("Stars");
                });

            modelBuilder.Entity("Exosky.Models.SharedSkyMap", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("Exosky.Models.SkyMap", b =>
                {
                    b.Navigation("Constellations");

                    b.Navigation("Stars");
                });

            modelBuilder.Entity("Exosky.Models.User", b =>
                {
                    b.Navigation("SavedSkyMaps");
                });
#pragma warning restore 612, 618
        }
    }
}
