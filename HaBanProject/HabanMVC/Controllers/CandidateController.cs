using HabanMVC.ViewModels.Candidate;
using Microsoft.AspNetCore.Mvc;

namespace HabanMVC.Controllers
{
    public class CandidateController : Controller
    {
        private readonly CandidateService _candidateService;
        private readonly ICandidateIndexVMService _candidateIndexVMService;
        private readonly FakeFavoriteJobVMService _fakeFavoriteJobVMService;
        private static int totalRows = -1;
        public CandidateController(CandidateService candidateService, ICandidateIndexVMService candidateIndexVMService, FakeFavoriteJobVMService fakeFavoriteJobVMService)
        {
            _candidateService = candidateService;
            _candidateIndexVMService = candidateIndexVMService;
            _fakeFavoriteJobVMService = fakeFavoriteJobVMService;
            if (totalRows == -1)
            {
                totalRows = _candidateService.GetAllSlider().Count();
            }
        }

        public async Task<IActionResult> Index()
        {
            //CandidateIndexViewModel result = _candidateService.GetAllCandidate();
            var vm = await _candidateIndexVMService.GetCandidateViewModel();
            return View(vm);
        }

        public IActionResult FavoriteCompany(int id = 1)
        {
            CandidateIndexViewModel result = _candidateService.GetAllCandidate();


            int activePage = id;
            int pageRows = 15;
            int Pages = 0;
            if (totalRows % pageRows == 0)
            {
                Pages = totalRows / pageRows;
            }
            else
            {
                Pages = (totalRows / pageRows) + 1;
            }

            int startRow = (activePage - 1) * pageRows;
            var results = _candidateService.GetAllCandidate().CollectionCompanyViewModel.OrderByDescending(x => x.CreationDate).Skip(startRow).Take(pageRows).ToList();


            ViewData["Active"] = 1;
            ViewData["ActivePage"] = id;
            ViewData["Pages"] = Pages;

            return View(results);
        }
        public IActionResult JobRecord(int id = 1)
        {
            CandidateIndexViewModel result = _candidateService.GetAllCandidate();


            int activePage = id;
            int pageRows = 15;
            int Pages = 0;
            if (totalRows % pageRows == 0)
            {
                Pages = totalRows / pageRows;
            }
            else
            {
                Pages = (totalRows / pageRows) + 1;
            }

            int startRow = (activePage - 1) * pageRows;
            var results = _candidateService.GetAllCandidate().ApplicationRecordViewModel.OrderByDescending(x => x.CreationDate).Skip(startRow).Take(pageRows).ToList();


            ViewData["Active"] = 1;
            ViewData["ActivePage"] = id;
            ViewData["Pages"] = Pages;


            return View(results);
        }

        public IActionResult Edit()
        {
            return View();
        }
        public  IActionResult FavoriteJob(int id = 1)
        {
            //List<JobSliderViewModel> JobSlider = _candidateService.GetAllSlider();
            //var vm = _fakeFavoriteJobVMService.GetFavoriteJob();

            int activePage = id;
            int pageRows = 15;
            int Pages = 0;
            if (totalRows % pageRows == 0)
            {
                Pages = totalRows / pageRows;
            }
            else
            {
                Pages = (totalRows / pageRows) +1 ;
            }

            int startRow = (activePage - 1) * pageRows;
            //JobSlider = _candidateService.GetAllSlider().OrderByDescending(x => x.CreationDate).Skip(startRow).Take(pageRows).ToList();
            var vm = _fakeFavoriteJobVMService.GetFavoriteJob().OrderByDescending(x => x.CreateAt).Skip(startRow).Take(pageRows).ToList();

            ViewData["Active"] = 1;  
            ViewData["ActivePage"] = id; 
            ViewData["Pages"] = Pages; 


            return View(vm);
        }

        public IActionResult ChatOverview()
        {
            var ChatOverviewView  = _candidateService.GetChatOverviewView();
            return View(ChatOverviewView);
        }

        public IActionResult Chat()
        {
            var viewmodel = _candidateService.GetChat();
            return View(viewmodel);
        }
        public IActionResult ResumeCenter()
        {
            var ResumeCenter = _candidateService.GetResumeCenterViewModel();
            return View(ResumeCenter);
        }
        public IActionResult ResumeEdit()
        {
            return View();
        }
        public IActionResult ResumeDisplay()
        {
            return View();
        }
    }
}
