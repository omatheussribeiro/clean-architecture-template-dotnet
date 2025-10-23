using clean_architecture_dotnet.Domain.Entities.Base;
using clean_architecture_dotnet.Domain.Entities.Expenses;
using clean_architecture_dotnet.Domain.Entities.Incomes;
using clean_architecture_dotnet.Domain.Entities.Summaries;

namespace clean_architecture_dotnet.Domain.Entities.Users
{
    public class User : EntityBase
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool Status { get; set; }
        public virtual UserContact Contact { get; set; } = new UserContact();
        public virtual Income Income { get; set; } = new Income();
        public virtual Expense Expense { get; set; } = new Expense();
        public virtual Summary Summary { get; set; } = new Summary();
    }
}
