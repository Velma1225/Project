using HabanMVC.ViewModels.Company;
using HabanMVC.ViewModels.HaBan;
using Microsoft.EntityFrameworkCore;

namespace HabanMVC.Repositories
{
    public class CompanyRepository
    {
        //假的資料庫
        private readonly FakeHaBanContext _context;
        public CompanyRepository(FakeHaBanContext context)
        {
            _context = context;
        }

        public async Task<List<JobList>> ReadAllJobList()
        {
            List<JobList> result = await _context.JobLists.ToListAsync();

            if (result.Count == 0)
            {
                return null;
            }

            return result;
        }
        
    }
}
