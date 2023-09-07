namespace HabanMVC.ViewModels.Company
{
    public class CoverLetterViewModel
    {
        public int CompanyId { get; set; }
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }

        public int JobDescriptionId { get; set; }

        public string JobTitle { get; set; }

        public int ResumeSnapshotId { get; set; }

        public bool ReadStatus { get; set; }

        public bool InterviewStatus { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
