﻿// <auto-generated />
using Baithuchanh.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Baithuchanh.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("Baithuchanh.Models.Student", b =>
                {
                    b.Property<string>("MaStudent")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameStudent")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhonumberStudent")
                        .HasColumnType("TEXT");

                    b.HasKey("MaStudent");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
