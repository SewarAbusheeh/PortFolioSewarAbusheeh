﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortFolioSewar.Data;

namespace PortFolioSewar.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230217180413_addmig")]
    partial class addmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PortFolioSewar.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("PortFolioSewar.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("BigDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Freelance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JObName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("PortFolioSewar.Models.Portfolio", b =>
                {
                    b.Property<int>("PortfolioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProjectDescDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("db")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PortfolioId");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("PortFolioSewar.Models.Resume", b =>
                {
                    b.Property<int>("ResumeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eamil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceDes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceDesc1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceDesc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceDesc3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceDesc4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceDesc5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoppyDesc1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoppyDesc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoppyDesc3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoppyDesc4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoppyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summarydesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResumeId");

                    b.ToTable("Resumes");
                });
#pragma warning restore 612, 618
        }
    }
}
