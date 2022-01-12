﻿// <auto-generated />
using System;
using Manager.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Manager.API.Migrations
{
    [DbContext(typeof(ManagerDbContext))]
    partial class ManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Manager.API.Models.JobPeriodicityModel", b =>
                {
                    b.Property<Guid>("Guid")
                        .HasColumnType("uuid")
                        .HasColumnName("Guid");

                    b.Property<bool>("IsJobEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("IsJobEnabled");

                    b.Property<string>("Periodicity")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Periodicity");

                    b.HasKey("Guid")
                        .HasName("PK_JobPeriodicity");

                    b.ToTable("JobPeriodicities", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
