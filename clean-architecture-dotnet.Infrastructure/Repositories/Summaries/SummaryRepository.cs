using clean_architecture_dotnet.Domain.Entities.Summaries;
using clean_architecture_dotnet.Infrastructure.Context;
using clean_architecture_dotnet.Infrastructure.Repositories.Summaries.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace clean_architecture_dotnet.Infrastructure.Repositories.Summaries
{
    public class SummaryRepository : ISummaryRepository
    {
        private ApplicationDbContext _context;

        public SummaryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Summary>> GetAll()
        {
            return await _context.Summaries.ToListAsync();
        }

        public async Task<Summary> GetById(int id)
        {
            return await _context.Summaries.AsNoTracking().Where(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Summary> Put(Summary summary)
        {
            summary.ChangeDate = DateTime.UtcNow;

            _context.Summaries.Update(summary);
            await _context.SaveChangesAsync();

            return summary;
        }

        public async Task<Summary> Post(Summary summary)
        {
            summary.CreationDate = DateTime.UtcNow;

            _context.Summaries.Add(summary);
            await _context.SaveChangesAsync();

            return summary;
        }

        public async Task<Summary> Delete(Summary summary)
        {
            _context.Summaries.Remove(summary);
            await _context.SaveChangesAsync();

            return summary;
        }
    }
}
