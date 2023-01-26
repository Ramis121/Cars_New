﻿// <auto-generated />
using System;
using Cars_New.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cars_New.Migrations
{
    [DbContext(typeof(CarDbContext))]
    [Migration("20221112194904_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cars_New.Models.Basket", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.Property<string>("Steering")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("guarantee")
                        .HasColumnType("integer");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("longDisk")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("phone")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("sum")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("wheels")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("year")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("baskets");
                });

            modelBuilder.Entity("Cars_New.Models.Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.Property<string>("Steering")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("guarantee")
                        .HasColumnType("integer");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("longDisk")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("phone")
                        .HasColumnType("integer");

                    b.Property<int>("sum")
                        .HasColumnType("integer");

                    b.Property<string>("wheels")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("year")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("cars");
                });
#pragma warning restore 612, 618
        }
    }
}
