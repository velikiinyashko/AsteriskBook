﻿// <auto-generated />
using AsteriskBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AsteriskBook.Migrations
{
    [DbContext(typeof(BaseContext))]
    partial class BaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("AsteriskBook.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("AsteriskBook.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("PathPhoneBook");

                    b.HasKey("Id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("AsteriskBook.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("AsteriskBook.Models.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BookId");

                    b.Property<string>("Group");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.Property<string>("Other");

                    b.Property<int>("Ring");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("AsteriskBook.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AsteriskBook.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BookId");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Login");

                    b.Property<string>("MacPhone");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Path");

                    b.Property<int>("Phone");

                    b.Property<int?>("RoleId");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AsteriskBook.Models.Department", b =>
                {
                    b.HasOne("AsteriskBook.Models.Company", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("AsteriskBook.Models.Record", b =>
                {
                    b.HasOne("AsteriskBook.Models.Book", "Book")
                        .WithMany("Records")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("AsteriskBook.Models.User", b =>
                {
                    b.HasOne("AsteriskBook.Models.Book", "Books")
                        .WithOne("Users")
                        .HasForeignKey("AsteriskBook.Models.User", "BookId");

                    b.HasOne("AsteriskBook.Models.Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("AsteriskBook.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
