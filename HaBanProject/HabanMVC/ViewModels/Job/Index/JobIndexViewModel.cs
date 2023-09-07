namespace HabanMVC.ViewModels.Job.Index
{
    public class JobIndexViewModel
    {
        public List<JobIndexCardViewModel> JobList { get; set; }
        public List<FreshSearchViewModel> FreshSearchList { get; set; }
    }

    public class FreshSearchViewModel
    {
        public string SearchItem { get; set; }
        public string KeywordUrl { get; set; }
    }
}
