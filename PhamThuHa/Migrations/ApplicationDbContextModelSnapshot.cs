﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PhamThuHa.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("PhamThuHa.Models.Student", b =>
                {
                    b.Property<string>("MaStudent")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChiStudent")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameStudent")
                        .HasColumnType("TEXT");

                    b.HasKey("MaStudent");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
