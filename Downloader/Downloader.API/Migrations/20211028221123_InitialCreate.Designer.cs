﻿// <auto-generated />
using System;
using Downloader.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Downloader.API.Migrations
{
    [DbContext(typeof(DownloaderDbContext))]
    [Migration("20211028221123_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Downloader.API.Models.RssSource", b =>
                {
                    b.Property<Guid>("Guid")
                        .HasColumnType("uuid")
                        .HasColumnName("Guid");

                    b.Property<DateTime>("LastSuccessDownloading")
                        .HasColumnType("timestamp")
                        .HasColumnName("LastSuccessDownloading");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("Url");

                    b.HasKey("Guid")
                        .HasName("PK_RssSource");

                    b.ToTable("RssSources");
                });
#pragma warning restore 612, 618
        }
    }
}
