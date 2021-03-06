﻿// <auto-generated />
using System;
using MediaApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MediaApi.Migrations
{
    [DbContext(typeof(MediaDataContext))]
    partial class MediaDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediaApi.Domain.MediaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Consumed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DateConsumed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecommendedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Removed")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("MediaItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Consumed = false,
                            Kind = "game",
                            RecommendedBy = "Henry",
                            Removed = false,
                            Title = "Super Mario Kart"
                        },
                        new
                        {
                            Id = 2,
                            Consumed = true,
                            DateConsumed = new DateTime(2020, 6, 18, 13, 29, 28, 27, DateTimeKind.Local).AddTicks(9000),
                            Kind = "show",
                            RecommendedBy = "Violet",
                            Removed = false,
                            Title = "Riverdale"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
