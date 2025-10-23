using clean_architecture_dotnet.Domain.Entities.Incomes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Incomes
{
    public class IncomeTypeConfiguration : IEntityTypeConfiguration<IncomeType>
    {
        public void Configure(EntityTypeBuilder<IncomeType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.CreationDate).IsRequired();

            builder.Property(p => p.ChangeDate);

            builder.Property(p => p.DeletionDate);

            builder.Property(p => p.Name).IsRequired();

            builder.Property(p => p.Description).IsRequired();

            builder.Property(p => p.Status).IsRequired();

            builder
              .HasOne(u => u.Income)
              .WithMany(c => c.IncomeType)
              .HasForeignKey(c => c.Id)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
