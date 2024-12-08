﻿// <auto-generated />
using System;
using AppDiyet.Repo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppDiyet.Repo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241208215908_initialConfig6")]
    partial class initialConfig6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppDiyet.Core.Concretes.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Calories")
                        .HasColumnType("decimal(7,2)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("FoodCategoriesId")
                        .HasColumnType("int");

                    b.Property<decimal>("FoodWeight")
                        .HasColumnType("decimal(7,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Proteins")
                        .HasColumnType("decimal(7,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoriesId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("AppDiyet.Core.Concretes.FoodCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("AppDiyet.Core.Concretes.FoodCategoriesMeals", b =>
                {
                    b.Property<int>("FoodCategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("MealsId")
                        .HasColumnType("int");

                    b.HasKey("FoodCategoriesId", "MealsId");

                    b.HasIndex("MealsId");

                    b.ToTable("FoodCategoriesMeals");
                });

            modelBuilder.Entity("AppDiyet.Core.Concretes.Meals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MealName")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("AppDiyet.Core.Concretes.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Activities")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Lenght")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("MealsCount")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("TargetWeight")
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Password")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AppDiyet.Core.Concretes.Food", b =>
                {
                    b.HasOne("AppDiyet.Core.Concretes.FoodCategories", "FoodCategories")
                        .WithMany("Foods")
                        .HasForeignKey("FoodCategoriesId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FoodCategories");
                });

            modelBuilder.Entity("AppDiyet.Core.Concretes.FoodCategoriesMeals", b =>
                {
                    b.HasOne("AppDiyet.Core.Concretes.FoodCategories", "FoodCategories")
                        .WithMany()
                        .HasForeignKey("FoodCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDiyet.Core.Concretes.Meals", "Meals")
                        .WithMany()
                        .HasForeignKey("MealsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategories");

                    b.Navigation("Meals");
                });

            modelBuilder.Entity("AppDiyet.Core.Concretes.Meals", b =>
                {
                    b.HasOne("AppDiyet.Core.Concretes.Users", "Users")
                        .WithMany("Meals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AppDiyet.Core.Concretes.FoodCategories", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("AppDiyet.Core.Concretes.Users", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
