using clean_architecture_dotnet.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Users
{
    public class UserContactConfiguration : IEntityTypeConfiguration<UserContact>
    {
        public void Configure(EntityTypeBuilder<UserContact> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.CreationDate).IsRequired();

            builder.Property(p => p.ChangeDate);

            builder.Property(p => p.DeletionDate);

            builder.Property(p => p.PhoneNumber).IsRequired();

            builder.Property(p => p.Status).IsRequired();

            builder.Property(p => p.UserId).IsRequired();

            builder
                .HasMany(ua => ua.User)
                .WithOne(u => u.Contact)
                .HasForeignKey(ua => ua.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new UserContact
                {
                    Id = 1,
                    CreationDate = DateTime.UtcNow,
                    ChangeDate = null,
                    DeletionDate = null,
                    PhoneNumber = "+00 (00) 00000-0000",
                    Status = true,
                    UserId = 1,
                });
        }
    }
}
