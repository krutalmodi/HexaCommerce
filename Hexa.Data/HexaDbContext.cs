﻿using Hexa.Core.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace Hexa.Data
{
    public class HexaDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerRole> CustomerRoles { get; set; }
        public DbSet<CustomerCustomerRole> CustomerCustomerRoles { get; set; }
        public DbSet<TokenManager> TokenManager { get; set; }

        public HexaDbContext(DbContextOptions<HexaDbContext> options) : base(options)
        { }

        public HexaDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !String.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                && type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}