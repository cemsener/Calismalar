﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StokTakip.EntityFramework;

#nullable disable

namespace StokTakip.Migrations
{
    [DbContext(typeof(StokTakipContext))]
    [Migration("20230604073156_Versiyon.1.0")]
    partial class Versiyon10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StokTakip.Model.Kullanici", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("StokTakip.Model.Musteri", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("StokTakip.Model.Urun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("StokTakip.Model.UrunDetayi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DelUser")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("ID_Musteri")
                        .HasColumnType("int");

                    b.Property<int>("ID_Urun")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModUser")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("UrunDetayi");
                });
#pragma warning restore 612, 618
        }
    }
}