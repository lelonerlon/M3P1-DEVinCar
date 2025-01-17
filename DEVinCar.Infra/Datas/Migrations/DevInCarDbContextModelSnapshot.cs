﻿// <auto-generated />
using System;
using DEVinCar.Infra.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DEVinCar.Infra.Datas.Migrations
{
    [DbContext(typeof(DevInCarDbContext))]
    partial class DevInCarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DEVinCar.Domain.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SuggestedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryForecast")
                        .HasColumnType("datetime2");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("SaleId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<int?>("UserBuyerId")
                        .HasColumnType("int");

                    b.Property<int?>("UserSellerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserBuyerId");

                    b.HasIndex("UserSellerId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.SaleCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleCars");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Initials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jose@email.com",
                            Name = "Jose",
                            Password = "123456opp78",
                            Role = "Gerente"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1999, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "andrea@email.com",
                            Name = "Andrea",
                            Password = "987dasd654321",
                            Role = "Vendedor"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2005, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adao@email.com",
                            Name = "Adao",
                            Password = "2589asd",
                            Role = "Comprador"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2001, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "monique@email.com",
                            Name = "Monique",
                            Password = "asd45uio",
                            Role = "Gerente"
                        });
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.Address", b =>
                {
                    b.HasOne("DEVinCar.Domain.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.City", b =>
                {
                    b.HasOne("DEVinCar.Domain.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.Delivery", b =>
                {
                    b.HasOne("DEVinCar.Domain.Models.Address", "Address")
                        .WithMany("Deliveries")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DEVinCar.Domain.Models.Sale", "Sale")
                        .WithMany("Deliveries")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.Sale", b =>
                {
                    b.HasOne("DEVinCar.Domain.Models.User", "UserBuyer")
                        .WithMany()
                        .HasForeignKey("UserBuyerId");

                    b.HasOne("DEVinCar.Domain.Models.User", "UserSeller")
                        .WithMany()
                        .HasForeignKey("UserSellerId");

                    b.Navigation("UserBuyer");

                    b.Navigation("UserSeller");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.SaleCar", b =>
                {
                    b.HasOne("DEVinCar.Domain.Models.Car", "Car")
                        .WithMany("Sales")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DEVinCar.Domain.Models.Sale", "Sale")
                        .WithMany("Cars")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.Address", b =>
                {
                    b.Navigation("Deliveries");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.Car", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.Sale", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Deliveries");
                });

            modelBuilder.Entity("DEVinCar.Domain.Models.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
