﻿// <auto-generated />
using System;
using Avtosolon.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Avtosolon.Migrations
{
    [DbContext(typeof(DBContent))]
    [Migration("20210310141858_Korzina")]
    partial class Korzina
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Avtosolon.Data.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatDesc");

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("dbCategories");
                });

            modelBuilder.Entity("Avtosolon.Data.Models.DanniyeKorzini", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarsId");

                    b.Property<string>("IdKorzini");

                    b.Property<int>("price");

                    b.HasKey("Id");

                    b.HasIndex("CarsId");

                    b.ToTable("danniyeKorzini");
                });

            modelBuilder.Entity("Avtosolon.Data.Models.InfoCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Avaible");

                    b.Property<int>("CatID");

                    b.Property<int?>("CategoriesId");

                    b.Property<bool>("Favourite");

                    b.Property<string>("Image");

                    b.Property<string>("LongDesc");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<string>("SortDesc");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.ToTable("dbInfoCar");
                });

            modelBuilder.Entity("Avtosolon.Data.Models.DanniyeKorzini", b =>
                {
                    b.HasOne("Avtosolon.Data.Models.InfoCar", "Cars")
                        .WithMany()
                        .HasForeignKey("CarsId");
                });

            modelBuilder.Entity("Avtosolon.Data.Models.InfoCar", b =>
                {
                    b.HasOne("Avtosolon.Data.Models.Categories", "Categories")
                        .WithMany("CarsList")
                        .HasForeignKey("CategoriesId");
                });
#pragma warning restore 612, 618
        }
    }
}