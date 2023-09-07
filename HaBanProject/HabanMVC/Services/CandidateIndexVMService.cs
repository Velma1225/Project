using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using HabanMVC.ViewModels.Candidate;

namespace HabanMVC.Services
{
    public class CandidateIndexVMService : ICandidateIndexVMService
    {
        private readonly IRepository<Candidate> _candidateRepo;

        public async Task<CandidateIndexVM> GetCandidateViewModel()
        {
            CandidateIndexVM vm = new CandidateIndexVM()
            {
                CandidateInfo = new CandidateInfoVM()
                {

                },
                ApplicationRecords = new List<ApplicationRecordsVM>()
                {

                },
                FavoriteJob = new List<FavoriteJobVM>()
                {

                },
                FavoriteCompany = new List<FavoriteCompanyVM>()
                {

                }


            };
            return vm;
        }
    }
}

