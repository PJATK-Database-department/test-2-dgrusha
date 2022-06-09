﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTask2.Models;

namespace WebTask2.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20220609085014_TestInit")]
    partial class TestInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebTask2.Models.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("IdClient");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            IdClient = 1,
                            FirstName = "string1",
                            LastName = "String2"
                        },
                        new
                        {
                            IdClient = 2,
                            FirstName = "string3",
                            LastName = "String4"
                        },
                        new
                        {
                            IdClient = 3,
                            FirstName = "string5",
                            LastName = "String6"
                        });
                });

            modelBuilder.Entity("WebTask2.Models.ClientOrder", b =>
                {
                    b.Property<int>("IdClientOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comments")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDClient")
                        .HasColumnType("int");

                    b.Property<int>("IDEmployee")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdClientOrder");

                    b.HasIndex("IDClient");

                    b.HasIndex("IDEmployee");

                    b.ToTable("ClientOrders");

                    b.HasData(
                        new
                        {
                            IdClientOrder = 1,
                            Comments = "dadaczcz",
                            CompletionDate = new DateTime(2022, 6, 10, 10, 50, 13, 998, DateTimeKind.Local).AddTicks(8593),
                            IDClient = 1,
                            IDEmployee = 1,
                            OrderDate = new DateTime(2022, 6, 9, 10, 50, 13, 996, DateTimeKind.Local).AddTicks(3772)
                        },
                        new
                        {
                            IdClientOrder = 2,
                            Comments = "dadaczdadadacz",
                            CompletionDate = new DateTime(2022, 6, 11, 10, 50, 13, 999, DateTimeKind.Local).AddTicks(313),
                            IDClient = 2,
                            IDEmployee = 2,
                            OrderDate = new DateTime(2022, 6, 9, 10, 50, 13, 999, DateTimeKind.Local).AddTicks(299)
                        },
                        new
                        {
                            IdClientOrder = 3,
                            Comments = "dadaczcdadadadddadaz",
                            CompletionDate = new DateTime(2022, 6, 12, 10, 50, 13, 999, DateTimeKind.Local).AddTicks(319),
                            IDClient = 3,
                            IDEmployee = 3,
                            OrderDate = new DateTime(2022, 6, 9, 10, 50, 13, 999, DateTimeKind.Local).AddTicks(317)
                        });
                });

            modelBuilder.Entity("WebTask2.Models.Confectionary_ClientOrder", b =>
                {
                    b.Property<int>("IdClientOrder")
                        .HasColumnType("int");

                    b.Property<int>("IdConfectionary")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("IdClientOrder", "IdConfectionary");

                    b.HasIndex("IdConfectionary");

                    b.ToTable("Confectionary_ClientOrders");

                    b.HasData(
                        new
                        {
                            IdClientOrder = 1,
                            IdConfectionary = 1,
                            Amount = 20,
                            Comments = "dadaczcz"
                        },
                        new
                        {
                            IdClientOrder = 2,
                            IdConfectionary = 2,
                            Amount = 30,
                            Comments = "dadacdadazcz"
                        },
                        new
                        {
                            IdClientOrder = 3,
                            IdConfectionary = 3,
                            Amount = 40,
                            Comments = "dadacdadazdadacz"
                        },
                        new
                        {
                            IdClientOrder = 3,
                            IdConfectionary = 4,
                            Amount = 50,
                            Comments = "dada1111dadazdadacz"
                        });
                });

            modelBuilder.Entity("WebTask2.Models.Confectionery", b =>
                {
                    b.Property<int>("IdConfectionery")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("PricePerOne")
                        .HasColumnType("real");

                    b.HasKey("IdConfectionery");

                    b.ToTable("Confectioneries");

                    b.HasData(
                        new
                        {
                            IdConfectionery = 1,
                            Name = "string1",
                            PricePerOne = 5.75f
                        },
                        new
                        {
                            IdConfectionery = 2,
                            Name = "string2",
                            PricePerOne = 5.75f
                        },
                        new
                        {
                            IdConfectionery = 3,
                            Name = "string3",
                            PricePerOne = 5.75f
                        },
                        new
                        {
                            IdConfectionery = 4,
                            Name = "string4",
                            PricePerOne = 5.75f
                        });
                });

            modelBuilder.Entity("WebTask2.Models.Employee", b =>
                {
                    b.Property<int>("IdEmployee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdEmployee");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            IdEmployee = 1,
                            FirstName = "string1",
                            LastName = "String2"
                        },
                        new
                        {
                            IdEmployee = 2,
                            FirstName = "string3",
                            LastName = "String4"
                        },
                        new
                        {
                            IdEmployee = 3,
                            FirstName = "string5",
                            LastName = "String6"
                        });
                });

            modelBuilder.Entity("WebTask2.Models.ClientOrder", b =>
                {
                    b.HasOne("WebTask2.Models.Client", "client")
                        .WithMany("ClientOrders")
                        .HasForeignKey("IDClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebTask2.Models.Employee", "employee")
                        .WithMany("ClientOrders")
                        .HasForeignKey("IDEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("WebTask2.Models.Confectionary_ClientOrder", b =>
                {
                    b.HasOne("WebTask2.Models.ClientOrder", "ClientOrder")
                        .WithMany("Confectionary_ClientOrders")
                        .HasForeignKey("IdClientOrder")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebTask2.Models.Confectionery", "Confectionery")
                        .WithMany()
                        .HasForeignKey("IdConfectionary")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientOrder");

                    b.Navigation("Confectionery");
                });

            modelBuilder.Entity("WebTask2.Models.Client", b =>
                {
                    b.Navigation("ClientOrders");
                });

            modelBuilder.Entity("WebTask2.Models.ClientOrder", b =>
                {
                    b.Navigation("Confectionary_ClientOrders");
                });

            modelBuilder.Entity("WebTask2.Models.Employee", b =>
                {
                    b.Navigation("ClientOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
