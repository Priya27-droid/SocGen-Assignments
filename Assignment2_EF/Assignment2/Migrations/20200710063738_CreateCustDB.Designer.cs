﻿// <auto-generated />
using Assignment2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment2.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20200710063738_CreateCustDB")]
    partial class CreateCustDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment2.Entities.Customer", b =>
                {
                    b.Property<string>("Cid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cid");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
