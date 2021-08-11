﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

namespace Persistance.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210702232310_BookAppointment")]
    partial class BookAppointment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16");

            modelBuilder.Entity("Domain.Allergy", b =>
                {
                    b.Property<int>("AllergyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT");

                    b.HasKey("AllergyId");

                    b.ToTable("Allergy");
                });

            modelBuilder.Entity("Domain.Analysis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Results")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Analysis");
                });

            modelBuilder.Entity("Domain.BookAppointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecondName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BookAppointment");
                });

            modelBuilder.Entity("Domain.Covid19CasesCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cases")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Recoveries")
                        .HasColumnType("INTEGER");

                    b.Property<int>("deaths")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Covid19CasesCountry");
                });

            modelBuilder.Entity("Domain.CovidInfected", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("CovidName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CovidSurname")
                        .HasColumnType("TEXT");

                    b.Property<int>("FamilyMembers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CovidInfected");
                });

            modelBuilder.Entity("Domain.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DangerStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("Information")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("surname")
                        .HasColumnType("TEXT");

                    b.Property<int>("userkey")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
