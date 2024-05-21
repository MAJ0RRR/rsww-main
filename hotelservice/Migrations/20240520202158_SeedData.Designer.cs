﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using hotelservice.Models;

#nullable disable

namespace hotelservice.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20240520202158_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("hotelservice.Models.Discount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("hotelservice.Models.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("FoodPricePerPerson")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b9544f88-c68e-4dcf-8f0e-bce60b680468"),
                            City = "Berlin",
                            Country = "Germany",
                            FoodPricePerPerson = 20m,
                            Name = "Berlin Hotel",
                            Street = "Alexanderplatz"
                        },
                        new
                        {
                            Id = new Guid("9cc84410-13da-4d10-b485-b053bc22ddfb"),
                            City = "Gdansk",
                            Country = "Poland",
                            FoodPricePerPerson = 15m,
                            Name = "Gdansk Hotel",
                            Street = "Dluga"
                        },
                        new
                        {
                            Id = new Guid("52b1252e-9555-4933-a6e0-8b47477a133c"),
                            City = "Tokyo",
                            Country = "Japan",
                            FoodPricePerPerson = 25m,
                            Name = "Tokyo Hotel",
                            Street = "Shinjuku"
                        });
                });

            modelBuilder.Entity("hotelservice.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Size")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("31990f0a-59b5-4cfb-968e-0676d9ce6108"),
                            Count = 5,
                            HotelId = new Guid("b9544f88-c68e-4dcf-8f0e-bce60b680468"),
                            Price = 100m,
                            Size = 25
                        },
                        new
                        {
                            Id = new Guid("19439c33-13f9-4a18-8dea-8c0ef418f3ca"),
                            Count = 5,
                            HotelId = new Guid("b9544f88-c68e-4dcf-8f0e-bce60b680468"),
                            Price = 150m,
                            Size = 35
                        },
                        new
                        {
                            Id = new Guid("8cb00db1-8309-47ee-b27b-87c23aacdcda"),
                            Count = 5,
                            HotelId = new Guid("9cc84410-13da-4d10-b485-b053bc22ddfb"),
                            Price = 80m,
                            Size = 20
                        },
                        new
                        {
                            Id = new Guid("4155fad1-de49-46ce-b850-d6d617355642"),
                            Count = 5,
                            HotelId = new Guid("9cc84410-13da-4d10-b485-b053bc22ddfb"),
                            Price = 120m,
                            Size = 30
                        },
                        new
                        {
                            Id = new Guid("7931e403-43df-4fce-9dd8-9a84fc84fcf3"),
                            Count = 5,
                            HotelId = new Guid("52b1252e-9555-4933-a6e0-8b47477a133c"),
                            Price = 200m,
                            Size = 22
                        },
                        new
                        {
                            Id = new Guid("a53bb938-91d1-4c65-9fec-ea81ce33cf61"),
                            Count = 5,
                            HotelId = new Guid("52b1252e-9555-4933-a6e0-8b47477a133c"),
                            Price = 300m,
                            Size = 40
                        });
                });

            modelBuilder.Entity("hotelservice.Models.RoomReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CancelationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("RoomsId")
                        .HasColumnType("uuid");

                    b.Property<int>("RoomsReserved")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RoomsId");

                    b.ToTable("RoomReservations");
                });

            modelBuilder.Entity("hotelservice.Models.Discount", b =>
                {
                    b.HasOne("hotelservice.Models.Hotel", null)
                        .WithMany("Discounts")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hotelservice.Models.Room", b =>
                {
                    b.HasOne("hotelservice.Models.Hotel", null)
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hotelservice.Models.RoomReservation", b =>
                {
                    b.HasOne("hotelservice.Models.Room", null)
                        .WithMany("Bookings")
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hotelservice.Models.Hotel", b =>
                {
                    b.Navigation("Discounts");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("hotelservice.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
