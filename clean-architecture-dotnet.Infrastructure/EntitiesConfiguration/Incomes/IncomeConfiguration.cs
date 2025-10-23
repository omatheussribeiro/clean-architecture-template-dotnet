using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using clean_architecture_dotnet.Domain.Entities.Incomes;

namespace clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Incomes
{
    public class IncomeConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.CreationDate).IsRequired();

            builder.Property(p => p.ChangeDate);

            builder.Property(p => p.DeletionDate);

            builder.Property(p => p.UserId).IsRequired();

            builder.Property(p => p.IncomeTypeId).IsRequired();

            builder.Property(p => p.IncomeTypeCurrencyId).IsRequired();

            builder.Property(p => p.Name).IsRequired();

            builder.Property(p => p.Description).IsRequired();

            builder.Property(p => p.Amount).IsRequired();

            builder.Property(p => p.PaymentDate).IsRequired();

            builder.Property(p => p.FixedIncome).IsRequired();

            builder.Property(p => p.Status).IsRequired();

            builder
                .HasMany(ua => ua.User)
                .WithOne(u => u.Income)
                .HasForeignKey(ua => ua.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(ua => ua.IncomeType)
                .WithOne(u => u.Income)
                .HasForeignKey(ua => ua.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(ua => ua.IncomeTypeCurrency)
                .WithOne(u => u.Income)
                .HasForeignKey(ua => ua.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
