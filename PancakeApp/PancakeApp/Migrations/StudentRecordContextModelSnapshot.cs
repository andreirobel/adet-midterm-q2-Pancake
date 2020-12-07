﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PancakeApp.Data;

namespace PancakeApp.Migrations
{
    [DbContext(typeof(StudentRecordContext))]
    partial class StudentRecordContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PancakeApp.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Final_Assign1")
                        .HasColumnType("int");

                    b.Property<int>("Final_Assign2")
                        .HasColumnType("int");

                    b.Property<int>("Final_Assign3")
                        .HasColumnType("int");

                    b.Property<int>("Final_Quiz1")
                        .HasColumnType("int");

                    b.Property<int>("Final_Quiz2")
                        .HasColumnType("int");

                    b.Property<int>("Final_Quiz3")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Assign1")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Assign2")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Assign3")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Quiz1")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Quiz2")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Quiz3")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Assign1")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Assign2")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Assign3")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Quiz1")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Quiz2")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Quiz3")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Assign1")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Assign2")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Assign3")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Quiz1")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Quiz2")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Quiz3")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Grade");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Final_Assign1 = 6,
                            Final_Assign2 = 8,
                            Final_Assign3 = 8,
                            Final_Quiz1 = 7,
                            Final_Quiz2 = 7,
                            Final_Quiz3 = 7,
                            Midterm_Assign1 = 6,
                            Midterm_Assign2 = 5,
                            Midterm_Assign3 = 9,
                            Midterm_Quiz1 = 8,
                            Midterm_Quiz2 = 7,
                            Midterm_Quiz3 = 9,
                            Prefinal_Assign1 = 6,
                            Prefinal_Assign2 = 7,
                            Prefinal_Assign3 = 7,
                            Prefinal_Quiz1 = 5,
                            Prefinal_Quiz2 = 7,
                            Prefinal_Quiz3 = 9,
                            Prelim_Assign1 = 6,
                            Prelim_Assign2 = 7,
                            Prelim_Assign3 = 6,
                            Prelim_Quiz1 = 8,
                            Prelim_Quiz2 = 7,
                            Prelim_Quiz3 = 9,
                            UserID = 1
                        },
                        new
                        {
                            Id = 2,
                            Final_Assign1 = 6,
                            Final_Assign2 = 8,
                            Final_Assign3 = 8,
                            Final_Quiz1 = 8,
                            Final_Quiz2 = 7,
                            Final_Quiz3 = 9,
                            Midterm_Assign1 = 6,
                            Midterm_Assign2 = 8,
                            Midterm_Assign3 = 8,
                            Midterm_Quiz1 = 8,
                            Midterm_Quiz2 = 5,
                            Midterm_Quiz3 = 9,
                            Prefinal_Assign1 = 6,
                            Prefinal_Assign2 = 7,
                            Prefinal_Assign3 = 7,
                            Prefinal_Quiz1 = 5,
                            Prefinal_Quiz2 = 7,
                            Prefinal_Quiz3 = 9,
                            Prelim_Assign1 = 6,
                            Prelim_Assign2 = 7,
                            Prelim_Assign3 = 5,
                            Prelim_Quiz1 = 7,
                            Prelim_Quiz2 = 7,
                            Prelim_Quiz3 = 9,
                            UserID = 2
                        },
                        new
                        {
                            Id = 3,
                            Final_Assign1 = 6,
                            Final_Assign2 = 9,
                            Final_Assign3 = 8,
                            Final_Quiz1 = 5,
                            Final_Quiz2 = 7,
                            Final_Quiz3 = 7,
                            Midterm_Assign1 = 6,
                            Midterm_Assign2 = 8,
                            Midterm_Assign3 = 8,
                            Midterm_Quiz1 = 8,
                            Midterm_Quiz2 = 5,
                            Midterm_Quiz3 = 9,
                            Prefinal_Assign1 = 6,
                            Prefinal_Assign2 = 5,
                            Prefinal_Assign3 = 7,
                            Prefinal_Quiz1 = 5,
                            Prefinal_Quiz2 = 7,
                            Prefinal_Quiz3 = 9,
                            Prelim_Assign1 = 6,
                            Prelim_Assign2 = 7,
                            Prelim_Assign3 = 5,
                            Prelim_Quiz1 = 7,
                            Prelim_Quiz2 = 7,
                            Prelim_Quiz3 = 9,
                            UserID = 3
                        });
                });

            modelBuilder.Entity("PancakeApp.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GradeId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.HasIndex("UserId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("PancakeApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cavite",
                            Email = "carson_alexander@email.com",
                            FirstName = "Carson",
                            LastName = "Alexander",
                            Password = "1234",
                            Role = "2",
                            UserId = "100001"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cavite",
                            Email = "meredith_alonso@email.com",
                            FirstName = "Meredith",
                            LastName = "Alonso",
                            Password = "1234",
                            Role = "2",
                            UserId = "100002"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Cavite",
                            Email = "arturo_anand@email.com",
                            FirstName = "Arturo",
                            LastName = "Anand",
                            Password = "1234",
                            Role = "2",
                            UserId = "100003"
                        });
                });

            modelBuilder.Entity("PancakeApp.Models.Grade", b =>
                {
                    b.HasOne("PancakeApp.Models.User", "User")
                        .WithMany("Grades")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PancakeApp.Models.Student", b =>
                {
                    b.HasOne("PancakeApp.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId");

                    b.HasOne("PancakeApp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
