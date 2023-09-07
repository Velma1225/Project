namespace HabanMVC.ViewModels.Job.Description
{
    public class JobDescriptionViewModel
    {
        public int? Id { get; set; }
        public string JobId { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string CompanyUrl { get; set; }
        public string JobDescription { get; set; }
        public string SalaryPayment { get; set; }
        public string SalaryRange { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string JobTenure { get; set; }
        public string Education { get; set; }   
        public string JobShift { get; set; }
        public string WorkingHours { get; set; }
        public List<string> JobCategoryList { get; set; }
        public string EmploymentCategory { get; set; }
        public string Management { get; set; }
        public string Language { get; set; }
        public string DrivingLicense { get; set; }
        public string ComputerSkill { get; set; }
        public int VacancyNumber { get; set; }
        public List<string> JobFeatureList { get; set; }
        public DateTime CreateAt { get; set; }
        public string UpdateAt { get; set; }
        public DateTime? PostStartAt { get; set; }
        public DateTime? PostEndAt { get; set; }
        public DateTime? BoostEndAt { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactAddress { get; set; }
        public string PostScript { get; set; }
        public WidgetJDViewModel SimilarJob { get; set; }
        public WidgetJDViewModel MostVisitedJob { get; set; }
        public WidgetJDViewModel VisitedJob { get; set; }


    }

}
