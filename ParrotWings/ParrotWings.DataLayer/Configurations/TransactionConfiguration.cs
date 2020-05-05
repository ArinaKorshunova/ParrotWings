using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParrotWings.Core.Models;

namespace ParrotWings.DataLayer.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder
                   .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .HasOne(m => m.Account)
                .WithMany(a => a.Transactions)
                .HasForeignKey(m => m.AccountId);

            builder
                .Property(m => m.Amount)
                .IsRequired();

            builder
                .Property(m => m.ResultBalance)
                .IsRequired();

            builder
                .ToTable("Transactions");
        }
    }
}
