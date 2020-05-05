using Microsoft.EntityFrameworkCore;
using ParrotWings.Core.Models;
using ParrotWings.DataLayer.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParrotWings.DataLayer
{
    public class ParrotWingsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public ParrotWingsContext(DbContextOptions<ParrotWingsContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new UserConfiguration());

            builder
                .ApplyConfiguration(new AccountConfiguration());

            builder
                .ApplyConfiguration(new TransactionConfiguration());
        }
    }
}
