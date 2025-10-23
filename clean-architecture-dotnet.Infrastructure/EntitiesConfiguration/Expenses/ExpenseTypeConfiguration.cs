using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using clean_architecture_dotnet.Domain.Entities.Expenses;

namespace clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Expenses
{
    public class ExpenseTypeConfiguration : IEntityTypeConfiguration<ExpenseType>
    {
        public void Configure(EntityTypeBuilder<ExpenseType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.CreationDate).IsRequired();

            builder.Property(p => p.ChangeDate);

            builder.Property(p => p.DeletionDate);

            builder.Property(p => p.Name).IsRequired();

            builder.Property(p => p.Description).IsRequired();

            builder.Property(p => p.Icon).IsRequired();

            builder.Property(p => p.Status).IsRequired();

            builder
              .HasOne(u => u.Expense)
              .WithMany(c => c.ExpenseType)
              .HasForeignKey(c => c.Id)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
