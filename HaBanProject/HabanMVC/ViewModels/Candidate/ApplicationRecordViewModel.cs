using System.ComponentModel.DataAnnotations;

namespace HabanMVC.ViewModels.Candidate
{

    public class ApplicationRecordViewModel
    {
        public int ID { get; set; }
        public int CandidateID { get; set; }
        public string CompanyName { get; set; }
        public string AppliedPosition { get; set; }
        public string Resume { get; set; }
        public string ReadStatus { get; set; }
        public DateTime? ResponseDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CreateAt { get; set; }



    }
}
