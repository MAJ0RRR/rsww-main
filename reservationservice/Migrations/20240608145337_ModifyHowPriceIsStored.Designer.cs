﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using reservationservice.Persistence;

#nullable disable

namespace reservationservice.Migrations
{
    [DbContext(typeof(ReservationDbContext))]
    [Migration("20240608145337_ModifyHowPriceIsStored")]
    partial class ModifyHowPriceIsStored
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("reservationservice.Models.BeingPaidFor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CancellationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("BeingPaidFors");
                });

            modelBuilder.Entity("reservationservice.Models.HotelRoomReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("HotelRoomReservationObjectId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("PricePerRoomPerNight")
                        .HasColumnType("numeric");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uuid");

                    b.Property<int>("Size")
                        .HasColumnType("integer");

                    b.Property<int>("nRooms")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("HotelRoomReservations");
                });

            modelBuilder.Entity("reservationservice.Models.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CancellationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Finalized")
                        .HasColumnType("boolean");

                    b.Property<bool>("FoodIncluded")
                        .HasColumnType("boolean");

                    b.Property<decimal>("FoodPricePerNight")
                        .HasColumnType("numeric");

                    b.Property<string>("FromCity")
                        .HasColumnType("text");

                    b.Property<Guid>("FromDestinationTransport")
                        .HasColumnType("uuid");

                    b.Property<decimal>("FromTransportOptionPrice")
                        .HasColumnType("numeric");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uuid");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumAdults")
                        .HasColumnType("integer");

                    b.Property<int>("NumUnder10")
                        .HasColumnType("integer");

                    b.Property<int>("NumUnder18")
                        .HasColumnType("integer");

                    b.Property<int>("NumUnder3")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfNights")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("ReservedUntil")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ToCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ToDestinationTransport")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ToTransportOptionPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("TransportType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("reservationservice.Models.BeingPaidFor", b =>
                {
                    b.HasOne("reservationservice.Models.Reservation", null)
                        .WithMany("BeingPaidFors")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("reservationservice.Models.HotelRoomReservation", b =>
                {
                    b.HasOne("reservationservice.Models.Reservation", null)
                        .WithMany("HotelRoomReservations")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("reservationservice.Models.Reservation", b =>
                {
                    b.Navigation("BeingPaidFors");

                    b.Navigation("HotelRoomReservations");
                });
#pragma warning restore 612, 618
        }
    }
}