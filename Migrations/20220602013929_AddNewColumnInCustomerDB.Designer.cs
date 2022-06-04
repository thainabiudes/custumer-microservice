﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Context;

namespace Customers5._0.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20220602013929_AddNewColumnInCustomerDB")]
    partial class AddNewColumnInCustomerDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Customers.API.Model.Customer", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("Gender")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("customer");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Age = 25,
                            Email = "thaina.biudes@gmail.com",
                            Gender = "Female",
                            LastName = "Costa",
                            Name = "Thainá"
                        },
                        new
                        {
                            Id = 2L,
                            Age = 34,
                            Email = "ina_biudes@hotmail.com",
                            Gender = "Female",
                            LastName = "Costa",
                            Name = "Thais"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
