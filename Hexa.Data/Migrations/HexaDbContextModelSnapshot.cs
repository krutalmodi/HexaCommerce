﻿// <auto-generated />
using Hexa.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Hexa.Data.Migrations
{
    [DbContext(typeof(HexaDbContext))]
    partial class HexaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hexa.Core.Domain.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("AdminComment");

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<Guid>("CustomerGuid");

                    b.Property<bool>("Deleted");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("Email");

                    b.Property<int>("FailedLoginAttempts");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("PasswordSalt");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Hexa.Core.Domain.Customers.CustomerCustomerRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int>("CustomerId");

                    b.Property<int>("CustomerRoleId");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("CustomerRoleId");

                    b.ToTable("CustomerCustomerRoles");
                });

            modelBuilder.Entity("Hexa.Core.Domain.Customers.CustomerRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("Name");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("CustomerRoles");
                });

            modelBuilder.Entity("Hexa.Core.Domain.Customers.TokenManager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("ExpiresOn");

                    b.Property<DateTime>("IssuedOn");

                    b.Property<string>("TokenKey");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("TokenManager");
                });

            modelBuilder.Entity("Hexa.Core.Domain.Customers.CustomerCustomerRole", b =>
                {
                    b.HasOne("Hexa.Core.Domain.Customers.Customer", "Customer")
                        .WithMany("CustomerRoles")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hexa.Core.Domain.Customers.CustomerRole", "CustomerRole")
                        .WithMany("CustomerRoles")
                        .HasForeignKey("CustomerRoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hexa.Core.Domain.Customers.TokenManager", b =>
                {
                    b.HasOne("Hexa.Core.Domain.Customers.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}