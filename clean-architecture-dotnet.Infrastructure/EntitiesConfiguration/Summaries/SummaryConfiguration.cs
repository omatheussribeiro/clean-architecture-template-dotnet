using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using clean_architecture_dotnet.Domain.Entities.Summaries;

namespace clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Summaries
{
    public class SummaryConfiguration : IEntityTypeConfiguration<Summary>
    {
        public void Configure(EntityTypeBuilder<Summary> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.CreationDate).IsRequired();

            builder.Property(p => p.ChangeDate);

            builder.Property(p => p.DeletionDate);

            builder.Property(p => p.UserId).IsRequired();

            builder.Property(p => p.SummaryDate).IsRequired();

            builder.Property(p => p.TotalExpense).IsRequired();

            builder.Property(p => p.Balance).IsRequired();

            builder.Property(p => p.FinalBalance).IsRequired();

            builder.Property(p => p.YieldRate).IsRequired();

            builder.Property(p => p.Status).IsRequired();

            builder
                .HasMany(ua => ua.User)
                .WithOne(u => u.Summary)
                .HasForeignKey(ua => ua.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
