using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using clean_architecture_dotnet.Domain.Entities.Expenses;

namespace clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Expenses
{
    public class ExpenseTypeCurrencyConfiguration : IEntityTypeConfiguration<ExpenseTypeCurrency>
    {
        public void Configure(EntityTypeBuilder<ExpenseTypeCurrency> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.CreationDate).IsRequired();

            builder.Property(p => p.ChangeDate);

            builder.Property(p => p.DeletionDate);

            builder.Property(p => p.Name).IsRequired();

            builder.Property(p => p.Description).IsRequired();

            builder.Property(p => p.Currency).IsRequired();

            builder.Property(p => p.Status).IsRequired();

            builder
              .HasOne(u => u.Expense)
              .WithMany(c => c.ExpenseTypeCurrency)
              .HasForeignKey(c => c.Id)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
