using clean_architecture_dotnet.Domain.Entities.Expenses;
using clean_architecture_dotnet.Domain.Entities.Incomes;
using clean_architecture_dotnet.Domain.Entities.Summaries;
using clean_architecture_dotnet.Domain.Entities.Users;
using clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Expenses;
using clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Incomes;
using clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Summaries;
using clean_architecture_dotnet.Infrastructure.EntitiesConfiguration.Users;
using Microsoft.EntityFrameworkCore;

namespace clean_architecture_dotnet.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region Users Tables

        public DbSet<UserContact> UserContacts { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion

        #region Expenses Tables

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<ExpenseTypeCurrency> ExpenseTypeCurrencies { get; set; }

        #endregion

        #region Incomes Tables

        public DbSet<Income> Incomes { get; set; }
        public DbSet<IncomeType> IncomeTypes { get; set; }
        public DbSet<IncomeTypeCurrency> IncomeTypeCurrencies { get; set; }

        #endregion

        #region Summaries Table

        public DbSet<Summary> Summaries { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Users Configuration

            builder.ApplyConfiguration(new UserContactConfiguration());

            builder.ApplyConfiguration(new UserConfiguration());

            #endregion

            #region Expenses Configuration

            builder.ApplyConfiguration(new ExpenseTypeCurrencyConfiguration());

            builder.ApplyConfiguration(new ExpenseTypeConfiguration());

            builder.ApplyConfiguration(new ExpenseConfiguration());

            #endregion

            #region Incomes Configuration

            builder.ApplyConfiguration(new IncomeTypeCurrencyConfiguration());

            builder.ApplyConfiguration(new IncomeTypeConfiguration());

            builder.ApplyConfiguration(new IncomeConfiguration());

            #endregion

            #region Summaries Configuration

            builder.ApplyConfiguration(new SummaryConfiguration());

            #endregion
        }
    }
}
