using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using clean_architecture_dotnet.Domain.Entities.Expenses;

namespace clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Expenses
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.CreationDate).IsRequired();

            builder.Property(p => p.ChangeDate);

            builder.Property(p => p.DeletionDate);

            builder.Property(p => p.UserId).IsRequired();

            builder.Property(p => p.ExpenseTypeId).IsRequired();

            builder.Property(p => p.ExpenseTypeCurrencyId).IsRequired();

            builder.Property(p => p.Name).IsRequired();

            builder.Property(p => p.Description).IsRequired();

            builder.Property(p => p.Amount).IsRequired();

            builder.Property(p => p.PaymentDate).IsRequired();

            builder.Property(p => p.ExpirationDate).IsRequired();

            builder.Property(p => p.FixedExpense).IsRequired();

            builder.Property(p => p.Status).IsRequired();

            builder
                .HasMany(ua => ua.User)
                .WithOne(u => u.Expense)
                .HasForeignKey(ua => ua.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(ua => ua.ExpenseType)
                .WithOne(u => u.Expense)
                .HasForeignKey(ua => ua.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(ua => ua.ExpenseTypeCurrency)
                .WithOne(u => u.Expense)
                .HasForeignKey(ua => ua.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
