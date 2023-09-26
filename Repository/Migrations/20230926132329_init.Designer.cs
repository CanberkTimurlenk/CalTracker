﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Context;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(KaloriTakipDbContext))]
    [Migration("20230926132329_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.Aim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AimName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aims");
                });

            modelBuilder.Entity("Entities.Concrete.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Calorie")
                        .HasColumnType("float");

                    b.Property<double>("Carbonhidrate")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<int>("FoodCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("Entities.Concrete.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserAimId")
                        .HasColumnType("int");

                    b.Property<int>("UserDataId")
                        .HasColumnType("int");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UserAimId");

                    b.HasIndex("UserDataId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Concrete.UserAim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AimId")
                        .HasColumnType("int");

                    b.Property<double>("Coefficient")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AimId");

                    b.ToTable("UserAims");
                });

            modelBuilder.Entity("Entities.Concrete.UserData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BmiStatus")
                        .HasColumnType("int");

                    b.Property<double>("BodyMassIndex")
                        .HasColumnType("float");

                    b.Property<double>("DailyCalorie")
                        .HasColumnType("float");

                    b.Property<double>("DailyCarbonhidrate")
                        .HasColumnType("float");

                    b.Property<double>("DailyFat")
                        .HasColumnType("float");

                    b.Property<double>("DailyProtein")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("RequiredCalorie")
                        .HasColumnType("float");

                    b.Property<double>("WaterAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("UserDatas");
                });

            modelBuilder.Entity("Entities.Concrete.UserMeals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Calorie")
                        .HasColumnType("float");

                    b.Property<double>("Carbonhidrate")
                        .HasColumnType("float");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<DateTime>("MealDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MealTimes")
                        .HasColumnType("int");

                    b.Property<double>("Portion")
                        .HasColumnType("float");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<int?>("UserDataId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserMealsID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserDataId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMeals");
                });

            modelBuilder.Entity("Entities.Concrete.UserVerification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Verification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserVerifications");
                });

            modelBuilder.Entity("FoodUserMeals", b =>
                {
                    b.Property<int>("FoodsId")
                        .HasColumnType("int");

                    b.Property<int>("UserMealsId")
                        .HasColumnType("int");

                    b.HasKey("FoodsId", "UserMealsId");

                    b.HasIndex("UserMealsId");

                    b.ToTable("FoodUserMeals");
                });

            modelBuilder.Entity("Entities.Concrete.Food", b =>
                {
                    b.HasOne("Entities.Concrete.FoodCategory", "FoodCategory")
                        .WithMany("Foods")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.HasOne("Entities.Concrete.UserAim", null)
                        .WithMany("Users")
                        .HasForeignKey("UserAimId");

                    b.HasOne("Entities.Concrete.UserData", "UserData")
                        .WithMany()
                        .HasForeignKey("UserDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserData");
                });

            modelBuilder.Entity("Entities.Concrete.UserAim", b =>
                {
                    b.HasOne("Entities.Concrete.Aim", "Aim")
                        .WithMany()
                        .HasForeignKey("AimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aim");
                });

            modelBuilder.Entity("Entities.Concrete.UserMeals", b =>
                {
                    b.HasOne("Entities.Concrete.UserData", null)
                        .WithMany("UserMeals")
                        .HasForeignKey("UserDataId");

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.UserVerification", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithOne("UserVerification")
                        .HasForeignKey("Entities.Concrete.UserVerification", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodUserMeals", b =>
                {
                    b.HasOne("Entities.Concrete.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.UserMeals", null)
                        .WithMany()
                        .HasForeignKey("UserMealsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.FoodCategory", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("UserVerification")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.UserAim", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Concrete.UserData", b =>
                {
                    b.Navigation("UserMeals");
                });
#pragma warning restore 612, 618
        }
    }
}
