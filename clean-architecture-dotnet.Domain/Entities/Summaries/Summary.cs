using clean_architecture_dotnet.Domain.Entities.Base;
using clean_architecture_dotnet.Domain.Entities.Users;

namespace clean_architecture_dotnet.Domain.Entities.Summaries
{
    public class Summary: EntityBase
    {
        public int UserId { get; set; }
        public DateOnly SummaryDate { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal Balance { get; set; }
        public decimal FinalBalance { get; set; }
        public decimal YieldRate { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<User> User { get; set; }
        public Summary()
        {
            User = new HashSet<User>();
        }
    }
}
