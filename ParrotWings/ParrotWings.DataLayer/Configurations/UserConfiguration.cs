using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParrotWings.Core.Models;

namespace ParrotWings.DataLayer.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                   .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Login)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(m => m.Password)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .ToTable("Users");
        }
    }
}
