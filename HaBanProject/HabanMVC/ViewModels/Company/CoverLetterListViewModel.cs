using Microsoft.AspNetCore.Mvc.Rendering;

namespace HabanMVC.ViewModels.Company
{
    public class CoverLetterListViewModel
    {
        public List<CoverLetterViewModel> JobDescList {  get; set; }
        public List<SelectListItem> JobSelectItems { get; set; }
    }
}
