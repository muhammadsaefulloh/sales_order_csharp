﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesOrder.Data;

#nullable disable

namespace MSAEFULLOHC_.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240405080239_migration-6")]
    partial class migration6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PriceEntity", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriceId"));

                    b.Property<DateTime>("PriceValidateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PriceValidateTo")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PriceValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("PriceId");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("SalesOrder.Models.CustomerEntity", b =>
                {
                    b.Property<string>("CustId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CustName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SalesOrder.Models.ProductEntity", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.HasKey("ProductCode");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("SalesOrder.Models.SalesOrderEntity", b =>
                {
                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("SalesOrderNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("OrderDate");

                    b.ToTable("SalesOrder");
                });

            modelBuilder.Entity("SalesOrder.Models.SalesOrderInterfaceEntity", b =>
                {
                    b.Property<string>("SalesOrderNo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.HasKey("SalesOrderNo");

                    b.ToTable("SalesOrderInterface");
                });
#pragma warning restore 612, 618
        }
    }
}
