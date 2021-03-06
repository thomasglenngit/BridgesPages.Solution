﻿// <auto-generated />
using System;
using Architecture.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Architecture.Migrations
{
    [DbContext(typeof(ArchitectureContext))]
    partial class ArchitectureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Architecture.Models.Bridge", b =>
                {
                    b.Property<int>("BridgeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Architect");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<int>("Span");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("BridgeId");

                    b.ToTable("Bridges");

                    b.HasData(
                        new
                        {
                            BridgeId = 1,
                            Architect = "Joseph Strauss",
                            City = "San Francisco",
                            Country = "USA",
                            EndDate = new DateTime(1937, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Golden Gate",
                            Span = 1280,
                            StartDate = new DateTime(1933, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BridgeId = 2,
                            Architect = "John Bradfield",
                            City = "Sydney",
                            Country = "AUS",
                            EndDate = new DateTime(1932, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sydney Harbour",
                            Span = 1149,
                            StartDate = new DateTime(1928, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BridgeId = 3,
                            Architect = "Satoshi Kashima",
                            City = "Kobe, Iwaya",
                            Country = "JPN",
                            EndDate = new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Akashi Kaikyo",
                            Span = 3911,
                            StartDate = new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BridgeId = 4,
                            Architect = "Dr Michel Virlogeux",
                            City = "Millau",
                            Country = "FRA",
                            EndDate = new DateTime(2004, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Millau Viaduct",
                            Span = 2460,
                            StartDate = new DateTime(2001, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BridgeId = 5,
                            Architect = "John Augustus Roebling",
                            City = "Brooklyn, Manhattan",
                            Country = "USA",
                            EndDate = new DateTime(1883, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Brooklyn",
                            Span = 18334,
                            StartDate = new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
