﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace workday.Migrations
{
    [DbContext(typeof(WorkdayContext))]
    partial class WorkdayContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Workday.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("PersonalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Salary")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Workday.Models.VacationRequest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfRequest")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("From")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("To")
                        .HasColumnType("TEXT");

                    b.Property<bool>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("VacationRequest");
                });
#pragma warning restore 612, 618
        }
    }
}
