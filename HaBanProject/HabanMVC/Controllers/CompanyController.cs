using HabanMVC.Services;
using HabanMVC.ViewModels.Company;
using HabanMVC.ViewModels.HaBan;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace HabanMVC.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly AccountEditService _accountEditService;

        public CompanyController (ICompanyService companyService, AccountEditService accountEditService)
        {
            _companyService = companyService;
            _accountEditService = accountEditService;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public async Task<IActionResult> JobList()
        //{
        //    List<JobList> joblist = await _companyService.GetJobList();
            
        //    return View(joblist);
        //}

        
        
        public async Task<IActionResult> CoverLetterList(int? JobDescID)
        {
            CoverLetterListViewModel coverLetterListViewModel = new CoverLetterListViewModel();
            List<CoverLetterViewModel> coverLetters = await _companyService.GetCoverLetterList(JobDescID);
            coverLetterListViewModel.JobDescList = coverLetters;

           
           
            List<SelectListItem> jobSelectItems = new List<SelectListItem>()
            { 
                new SelectListItem()
                {
                    Value= null,
                    Text = "請選擇"
                }
            };
            
            coverLetterListViewModel.JobSelectItems = await _companyService.GetSelectListItems(JobDescID);

            return View(coverLetterListViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CoverLetterList(CoverLetterListRequest request)
        {
           
            return RedirectToAction("CoverLetterList" , new { JobDescID = request.JobDescID });
        }
      
        public IActionResult CompanyProfile()
        {
            CompanyProfileViewModel companyProfile = _companyService.GetCompanyProfile();
            return View(companyProfile);
        }

        public IActionResult CompanyProfileEdit()
        {
            CompanyProfileEditViewModel viewmodel = _companyService.GetCompanyProfileEdit();
            return View(viewmodel);
        }

       
        //public IActionResult BuyPoStep1()
        //{
        //    return View();
        //}

        public async Task<IActionResult> BuyPoStep1()
        {

            //MembershipBuyVM membershipBuyVM = new MembershipBuyVM();
            //List<MembershipCategoriesVM> membershipCategoriesList = await _companyService.GetMembershipCategory();

            //membershipBuyVM.MembershipCateList = membershipCategoriesList;

            //return View(membershipBuyVM);

            var vm =  await _companyService.GetMembershipModel();
            return View(vm);
        }

        public IActionResult BuyPoStep2()
        {
            return View();
        }

        public IActionResult BuyPoStep3()
        {

            return View();
        }
        public IActionResult BuyPoStep4()
        {

            return View();
        }

        public IActionResult BuyPoHistory()
        {
            return View();
        }
        public IActionResult BuyTopStep1()
        {
            return View();
        }

        public IActionResult BuyTopStep2()
        {
            return View();
        }
        public IActionResult BuyTopStep3()
        {

            return View();
        }
        public IActionResult BuyTopStep4()
        {

            return View();
        }
        public IActionResult BuyTopHistory()
        {
            return View();
        }

        public IActionResult UseTop()
        {
            return View();
        }

        public IActionResult UseTopHistory()
        {
            return View();
        }

        public IActionResult AccountEdit()
        {
            AccountEditViewModel accountEdit = _accountEditService.GetAccountEdit();
            return View(accountEdit);
        }
    }
    public class CoverLetterListRequest
    {
        public int JobDescID { get; set; }
        //public int SelectJob { get; set; }
    }
}
