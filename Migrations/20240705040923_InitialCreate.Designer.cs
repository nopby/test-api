﻿// <auto-generated />
using System;
using BETest.Persistences;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BETest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240705040923_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BETest.Models.Simulation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id_simulasi");

                    b.Property<int>("Bm")
                        .HasColumnType("integer");

                    b.Property<string>("KodeBarang")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Kode_barang");

                    b.Property<float>("NilaiBm")
                        .HasColumnType("real")
                        .HasColumnName("Nilai_bm");

                    b.Property<float>("NilaiKomoditas")
                        .HasColumnType("real")
                        .HasColumnName("Nilai_komoditas");

                    b.Property<string>("UraianBarang")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Uraian_barang");

                    b.Property<DateTime>("WaktuInsert")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Waktu_insert");

                    b.HasKey("Id");

                    b.ToTable("TB_SIMULATION", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
