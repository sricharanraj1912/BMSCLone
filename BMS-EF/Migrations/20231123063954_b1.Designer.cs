﻿// <auto-generated />
using System;
using BMS_EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BMS_EF.Migrations
{
    [DbContext(typeof(BMSDbcontext))]
    [Migration("20231123063954_b1")]
    partial class b1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BMS_EF.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPwd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("BMS_EF.BookTicket", b =>
                {
                    b.Property<int>("ShowNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowNo"), 1L, 1);

                    b.Property<int?>("MoviesMovieId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShowTimings")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TicketsAvailable")
                        .HasColumnType("int");

                    b.HasKey("ShowNo");

                    b.HasIndex("MoviesMovieId");

                    b.ToTable("BookTickets");
                });

            modelBuilder.Entity("BMS_EF.Cinema", b =>
                {
                    b.Property<int>("CinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CinemaId"), 1L, 1);

                    b.Property<string>("CinemaAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CinemaName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CinemaId");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("BMS_EF.MakePayment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("usersUserId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("usersUserId");

                    b.ToTable("makePayments");
                });

            modelBuilder.Entity("BMS_EF.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("MovieLang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("BMS_EF.RegisterUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int?>("PhNumber")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("RegisterUsers");
                });

            modelBuilder.Entity("BMS_EF.BookTicket", b =>
                {
                    b.HasOne("BMS_EF.Movie", "Movies")
                        .WithMany()
                        .HasForeignKey("MoviesMovieId");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("BMS_EF.MakePayment", b =>
                {
                    b.HasOne("BMS_EF.RegisterUser", "users")
                        .WithMany()
                        .HasForeignKey("usersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}