namespace HabanMVC.ViewModels.Company
{
    public class CompanyProfileEditViewModel
    {
        public string CompanyName { get; set; }
        public string CompanyLogoPic { get; set; }

        //統編
        public string CompanyAccount { get; set; }
        public string CompanyPhone { get; set; }
        public string Fax { get; set; }
        public string PersonnelContact { get; set; }
        public string StaffNumber { get; set; }
        public string IndustryCategory { get; set; }
        public string CompanySite { get; set; }
        public string Address { get; set; }
        public string Introduction { get; set; }

        //產品服務
        public string ProductContent { get; set; }

        //公司福利

        public List<CompanyFeatureViewModel> CompanyFeature { get; set; }
        public string Gift { get; set; }
        public string Insurance { get; set; }
        public string WelfareDetail { get; set; }
        public List<WorkShareViewModel> WorkShare { get; set; }
       
        public List<EnvironmentPicViewModel> EnvironmentPic { get; set; }
       
    }



    //public class WorkShareViewModel
    //{
    //    public string PositionCategory { get; set; }
    //    public int ShareEvaluation { get; set; }
    //    public string ShareContent { get; set; }

    //}



    //public class EnvironmentPicViewModel
    //{
    //    public string EnvironmentPicPath { get; set; }
    //}

    //public class CompanyFeatureViewModel
    //{
    //    public string CompanyFeatureName { get; set; }
    //}

 














}
