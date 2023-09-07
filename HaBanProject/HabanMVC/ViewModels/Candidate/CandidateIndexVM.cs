namespace HabanMVC.ViewModels.Candidate
{
    public class CandidateIndexVM
    {
        public CandidateInfoVM CandidateInfo { get; set; }
        public List<ApplicationRecordsVM> ApplicationRecords { get; set; }
        public List<FavoriteJobVM> FavoriteJob { get; set; }
        public List<FavoriteCompanyVM> FavoriteCompany { get; set; }
    }
}
