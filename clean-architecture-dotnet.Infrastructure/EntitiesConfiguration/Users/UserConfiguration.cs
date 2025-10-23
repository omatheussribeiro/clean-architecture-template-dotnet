using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using clean_architecture_dotnet.Domain.Entities.Users;

namespace clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Users
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.CreationDate).IsRequired();

            builder.Property(p => p.ChangeDate);

            builder.Property(p => p.DeletionDate);

            builder.Property(p => p.FirstName).IsRequired();

            builder.Property(p => p.LastName).IsRequired();

            builder.Property(p => p.Document).IsRequired();

            builder.Property(p => p.Email).IsRequired();

            builder.Property(p => p.Password).IsRequired();

            builder.Property(p => p.Status).IsRequired();

            builder
              .HasOne(u => u.Contact)
              .WithMany(c => c.User)
              .HasForeignKey(c => c.Id)
              .OnDelete(DeleteBehavior.Restrict);

            builder
              .HasOne(u => u.Income)
              .WithMany(c => c.User)
              .HasForeignKey(c => c.Id)
              .OnDelete(DeleteBehavior.Restrict);

            builder
             .HasOne(u => u.Expense)
             .WithMany(c => c.User)
             .HasForeignKey(c => c.Id)
             .OnDelete(DeleteBehavior.Restrict);

            builder
              .HasOne(u => u.Summary)
              .WithMany(c => c.User)
              .HasForeignKey(c => c.Id)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new User
                {
                    Id = 1,
                    CreationDate = DateTime.UtcNow,
                    ChangeDate = null,
                    DeletionDate = null,
                    FirstName = "Admin",
                    LastName = "Hello",
                    Document = "00.000.000/0000-00",
                    Email = "admin@admin.com",
                    Password = "admin123",
                    Status = true,
                });

        }
    }
}
