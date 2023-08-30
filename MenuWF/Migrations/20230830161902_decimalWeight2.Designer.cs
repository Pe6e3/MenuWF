﻿// <auto-generated />
using System;
using MenuWF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MenuWF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230830161902_decimalWeight2")]
    partial class decimalWeight2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MenuWF.Entities.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Салат овощной"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Борщ"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Салат Сингулярность"
                        });
                });

            modelBuilder.Entity("MenuWF.Entities.Journal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DishWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("meal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Journals");
                });

            modelBuilder.Entity("MenuWF.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Calories")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Carbs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Fats")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Prots")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 50m,
                            Carbs = 20m,
                            Fats = 0m,
                            Name = "Огурец",
                            Prots = 1m
                        },
                        new
                        {
                            Id = 2,
                            Calories = 80m,
                            Carbs = 15m,
                            Fats = 0m,
                            Name = "Картофель",
                            Prots = 2m
                        },
                        new
                        {
                            Id = 3,
                            Calories = 35m,
                            Carbs = 10m,
                            Fats = 0m,
                            Name = "Морковь",
                            Prots = 1m
                        },
                        new
                        {
                            Id = 4,
                            Calories = 250m,
                            Carbs = 0m,
                            Fats = 15m,
                            Name = "Говядина",
                            Prots = 20m
                        },
                        new
                        {
                            Id = 5,
                            Calories = 130m,
                            Carbs = 30m,
                            Fats = 1m,
                            Name = "Рис",
                            Prots = 3m
                        },
                        new
                        {
                            Id = 6,
                            Calories = 70m,
                            Carbs = 1m,
                            Fats = 5m,
                            Name = "Яйцо",
                            Prots = 6m
                        },
                        new
                        {
                            Id = 7,
                            Calories = 20m,
                            Carbs = 5m,
                            Fats = 0m,
                            Name = "Помидор",
                            Prots = 1m
                        },
                        new
                        {
                            Id = 8,
                            Calories = 180m,
                            Carbs = 0m,
                            Fats = 10m,
                            Name = "Курица",
                            Prots = 25m
                        },
                        new
                        {
                            Id = 9,
                            Calories = 150m,
                            Carbs = 2m,
                            Fats = 15m,
                            Name = "Сыр",
                            Prots = 10m
                        },
                        new
                        {
                            Id = 10,
                            Calories = 40m,
                            Carbs = 24m,
                            Fats = 0m,
                            Name = "Свекла",
                            Prots = 1m
                        },
                        new
                        {
                            Id = 11,
                            Calories = 50m,
                            Carbs = 26m,
                            Fats = 0m,
                            Name = "Капуста",
                            Prots = 1m
                        },
                        new
                        {
                            Id = 12,
                            Calories = 100m,
                            Carbs = 20m,
                            Fats = 1m,
                            Name = "Хлеб",
                            Prots = 3m
                        });
                });

            modelBuilder.Entity("MenuWF.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductWeight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("ProductId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DishId = 1,
                            ProductId = 1,
                            ProductWeight = 200m
                        },
                        new
                        {
                            Id = 2,
                            DishId = 1,
                            ProductId = 2,
                            ProductWeight = 150m
                        },
                        new
                        {
                            Id = 3,
                            DishId = 1,
                            ProductId = 3,
                            ProductWeight = 200m
                        },
                        new
                        {
                            Id = 4,
                            DishId = 2,
                            ProductId = 2,
                            ProductWeight = 300m
                        },
                        new
                        {
                            Id = 5,
                            DishId = 2,
                            ProductId = 3,
                            ProductWeight = 200m
                        },
                        new
                        {
                            Id = 6,
                            DishId = 2,
                            ProductId = 4,
                            ProductWeight = 300m
                        },
                        new
                        {
                            Id = 7,
                            DishId = 2,
                            ProductId = 7,
                            ProductWeight = 300m
                        },
                        new
                        {
                            Id = 8,
                            DishId = 2,
                            ProductId = 10,
                            ProductWeight = 100m
                        },
                        new
                        {
                            Id = 9,
                            DishId = 2,
                            ProductId = 11,
                            ProductWeight = 100m
                        },
                        new
                        {
                            Id = 10,
                            DishId = 3,
                            ProductId = 12,
                            ProductWeight = 200m
                        },
                        new
                        {
                            Id = 11,
                            DishId = 3,
                            ProductId = 5,
                            ProductWeight = 200m
                        },
                        new
                        {
                            Id = 12,
                            DishId = 3,
                            ProductId = 6,
                            ProductWeight = 200m
                        },
                        new
                        {
                            Id = 13,
                            DishId = 3,
                            ProductId = 8,
                            ProductWeight = 200m
                        },
                        new
                        {
                            Id = 14,
                            DishId = 3,
                            ProductId = 9,
                            ProductWeight = 300m
                        });
                });

            modelBuilder.Entity("MenuWF.Entities.Recipe", b =>
                {
                    b.HasOne("MenuWF.Entities.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MenuWF.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}