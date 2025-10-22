using clean_architecture_dotnet.Domain.Entities.Base;

namespace clean_architecture_dotnet.Domain.Entities.Incomes
{
    public class IncomeTypeCurrency : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public bool Status { get; set; }
        public virtual Income Income { get; set; } = new Income();
    }
}
