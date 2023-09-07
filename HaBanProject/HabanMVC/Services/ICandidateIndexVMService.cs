namespace HabanMVC.Services
{
    public interface ICandidateIndexVMService
    {
        Task<CandidateIndexVM> GetCandidateViewModel();
    }
}