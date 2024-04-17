﻿// <auto-generated />
using MVC_PH34491.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_PH34491.Migrations
{
    [DbContext(typeof(NulldContext))]
    [Migration("20240412182220_scss")]
    partial class scss
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_PH34491.Models.Ca", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DongVatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdDV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiSong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DongVatId");

                    b.ToTable("cas");
                });

            modelBuilder.Entity("MVC_PH34491.Models.DongVat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiSong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThucAn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DongVats");
                });

            modelBuilder.Entity("MVC_PH34491.Models.Ca", b =>
                {
                    b.HasOne("MVC_PH34491.Models.DongVat", "DongVat")
                        .WithMany("Cas")
                        .HasForeignKey("DongVatId");

                    b.Navigation("DongVat");
                });

            modelBuilder.Entity("MVC_PH34491.Models.DongVat", b =>
                {
                    b.Navigation("Cas");
                });
#pragma warning restore 612, 618
        }
    }
}
