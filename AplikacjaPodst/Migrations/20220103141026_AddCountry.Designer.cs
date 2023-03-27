﻿// <auto-generated />
using System;
using AplikacjaPodst.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AplikacjaPodst.Migrations
{
    [DbContext(typeof(WarzywaContext))]
    [Migration("20220103141026_AddCountry")]
    partial class AddCountry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AplikacjaPodst.Models.Warzywo", b =>
                {
                    b.Property<int>("WarzywoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("WarzywoId");

                    b.ToTable("Warzywa");

                    b.HasData(
                        new
                        {
                            WarzywoId = 1,
                            Country = "Włochy",
                            Name = "pomidor",
                            Price = 8.5m,
                            Quantity = 30
                        },
                        new
                        {
                            WarzywoId = 2,
                            Country = "Polska",
                            Name = "ziemniaki",
                            Price = 2.3m,
                            Quantity = 85
                        },
                        new
                        {
                            WarzywoId = 3,
                            Country = "Dania",
                            Name = "ogórek",
                            Price = 6m,
                            Quantity = 10
                        },
                        new
                        {
                            WarzywoId = 4,
                            Country = "Holandia",
                            Name = "kalafior",
                            Price = 5.99m,
                            Quantity = 40
                        },
                        new
                        {
                            WarzywoId = 5,
                            Country = "Szwecja",
                            Name = "cukinia",
                            Price = 4.6m,
                            Quantity = 16
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
