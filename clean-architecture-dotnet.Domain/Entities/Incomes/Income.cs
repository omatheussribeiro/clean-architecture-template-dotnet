using clean_architecture_dotnet.Domain.Entities.Base;
using clean_architecture_dotnet.Domain.Entities.Users;

namespace clean_architecture_dotnet.Domain.Entities.Incomes
{
    public class Income : EntityBase
    {
        public int UserId { get; set; }
        public int IncomeTypeId { get; set; }
        public int IncomeTypeCurrencyId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool FixedIncome { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<IncomeType> IncomeType { get; set; }
        public virtual ICollection<IncomeTypeCurrency> IncomeTypeCurrency { get; set; }

        public Income()
        {
            User = new HashSet<User>();
            IncomeType = new HashSet<IncomeType>();
            IncomeTypeCurrency = new HashSet<IncomeTypeCurrency>();
        }
    }
}
