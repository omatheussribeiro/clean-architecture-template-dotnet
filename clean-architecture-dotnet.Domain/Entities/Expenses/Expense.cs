using clean_architecture_dotnet.Domain.Entities.Base;
using clean_architecture_dotnet.Domain.Entities.Users;

namespace clean_architecture_dotnet.Domain.Entities.Expenses
{
    public class Expense : EntityBase
    {
        public int UserId { get; set; }
        public int ExpenseIncomeTypeId { get; set; }
        public int ExpenseTypeCurrencyId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool FixedExpense { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<ExpenseType> ExpenseType { get; set; }
        public virtual ICollection<ExpenseTypeCurrency> ExpenseTypeCurrency { get; set; }

        public Expense()
        {
            User = new HashSet<User>();
            ExpenseType = new HashSet<ExpenseType>();
            ExpenseTypeCurrency = new HashSet<ExpenseTypeCurrency>();
        }
    }
}
