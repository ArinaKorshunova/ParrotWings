using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParrotWings.Core.Models;

namespace ParrotWings.DataLayer.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder
                   .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .HasOne(m => m.User)
                .WithMany(a => a.Accounts)
                .HasForeignKey(m => m.UserId);

            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(m => m.Balance)
                .IsRequired();

            builder
                .ToTable("Accounts");
        }
    }
}
