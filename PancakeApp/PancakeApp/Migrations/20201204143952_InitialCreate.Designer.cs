﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PancakeApp.Data;

namespace PancakeApp.Migrations
{
    [DbContext(typeof(StudentRecordContext))]
    [Migration("20201204143952_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<float>("AveFinalAssign")
                        .HasColumnType("real");

                    b.Property<float>("AveFinalQuiz")
                        .HasColumnType("real");

                    b.Property<float>("AveMidtermAssign")
                        .HasColumnType("real");

                    b.Property<float>("AveMidtermQuiz")
                        .HasColumnType("real");

                    b.Property<float>("AvePrefinalAssign")
                        .HasColumnType("real");

                    b.Property<float>("AvePrefinalQuiz")
                        .HasColumnType("real");

                    b.Property<float>("AvePrelimAssign")
                        .HasColumnType("real");

                    b.Property<float>("AvePrelimQuiz")
                        .HasColumnType("real");

                    b.Property<float>("FinalGrade")
                        .HasColumnType("real");

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

                    b.Property<float>("MidtermGrade")
                        .HasColumnType("real");

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

                    b.Property<float>("PrefinalGrade")
                        .HasColumnType("real");

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

                    b.Property<float>("PrelimGrade")
                        .HasColumnType("real");

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

                    b.HasKey("Id");

                    b.ToTable("Grade");
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

                    b.Property<int?>("GradeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("User");
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

            modelBuilder.Entity("PancakeApp.Models.User", b =>
                {
                    b.HasOne("PancakeApp.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId");
                });
#pragma warning restore 612, 618
        }
    }
}
