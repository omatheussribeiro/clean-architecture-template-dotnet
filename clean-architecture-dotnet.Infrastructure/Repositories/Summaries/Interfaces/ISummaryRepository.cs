using clean_architecture_dotnet.Domain.Entities.Summaries;

namespace clean_architecture_dotnet.Infrastructure.Repositories.Summaries.Interfaces
{
    public interface ISummaryRepository
    {
        Task<IEnumerable<Summary>> GetAll();
        Task<Summary> GetById(int id);
        Task<Summary> Put(Summary user);
        Task<Summary> Post(Summary user);
        Task<Summary> Delete(Summary user);
    }
}
