﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.DbContextes;

#nullable disable

namespace Project1.Migrations
{
    [DbContext(typeof(LibraryDB))]
    partial class LibraryDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.7");

            modelBuilder.Entity("Project1.Entities.Cooperative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Driver_1Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Driver_2Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Driver_3Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Driver_4Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Driver_5Id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Driver_6Id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Driver_7Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Employee_1Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Employee_2Id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Employee_3Id")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PhoneNumber")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("Driver_1Id");

                    b.HasIndex("Driver_2Id");

                    b.HasIndex("Driver_3Id");

                    b.HasIndex("Driver_4Id");

                    b.HasIndex("Driver_5Id");

                    b.HasIndex("Driver_6Id");

                    b.HasIndex("Driver_7Id");

                    b.HasIndex("Employee_1Id");

                    b.HasIndex("Employee_2Id");

                    b.HasIndex("Employee_3Id");

                    b.ToTable("Cooperatives");
                });

            modelBuilder.Entity("Project1.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthCertificateNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("NationalCode")
                        .HasColumnType("REAL");

                    b.Property<double>("PhoneNumber")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasDiscriminator().HasValue("Employee");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Project1.Entities.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PhoneNumber")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("Project1.Entities.CEO", b =>
                {
                    b.HasBaseType("Project1.Entities.Employee");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<double>("Password")
                        .HasColumnType("REAL");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("CEO");
                });

            modelBuilder.Entity("Project1.Entities.Driver", b =>
                {
                    b.HasBaseType("Project1.Entities.Employee");

                    b.Property<double>("CertificateNumber")
                        .HasColumnType("REAL");

                    b.HasDiscriminator().HasValue("Driver");
                });

            modelBuilder.Entity("Project1.Entities.Cooperative", b =>
                {
                    b.HasOne("Project1.Entities.Driver", "Driver_1")
                        .WithMany()
                        .HasForeignKey("Driver_1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.Entities.Driver", "Driver_2")
                        .WithMany()
                        .HasForeignKey("Driver_2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.Entities.Driver", "Driver_3")
                        .WithMany()
                        .HasForeignKey("Driver_3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.Entities.Driver", "Driver_4")
                        .WithMany()
                        .HasForeignKey("Driver_4Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.Entities.Driver", "Driver_5")
                        .WithMany()
                        .HasForeignKey("Driver_5Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.Entities.Driver", "Driver_6")
                        .WithMany()
                        .HasForeignKey("Driver_6Id");

                    b.HasOne("Project1.Entities.Driver", "Driver_7")
                        .WithMany()
                        .HasForeignKey("Driver_7Id");

                    b.HasOne("Project1.Entities.Employee", "Employee_1")
                        .WithMany()
                        .HasForeignKey("Employee_1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.Entities.Employee", "Employee_2")
                        .WithMany()
                        .HasForeignKey("Employee_2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.Entities.Employee", "Employee_3")
                        .WithMany()
                        .HasForeignKey("Employee_3Id");

                    b.Navigation("Driver_1");

                    b.Navigation("Driver_2");

                    b.Navigation("Driver_3");

                    b.Navigation("Driver_4");

                    b.Navigation("Driver_5");

                    b.Navigation("Driver_6");

                    b.Navigation("Driver_7");

                    b.Navigation("Employee_1");

                    b.Navigation("Employee_2");

                    b.Navigation("Employee_3");
                });
#pragma warning restore 612, 618
        }
    }
}
