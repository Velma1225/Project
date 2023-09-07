using HabanMVC.ViewModels.HaBan;
using Microsoft.AspNetCore.Mvc;

namespace HabanMVC.Controllers
{
    public class HaBanController : Controller
    {
        private readonly IHaBanService _habanService;
        public HaBanController(IHaBanService habanService)
        { 
            _habanService = habanService;
        }
        public async Task<IActionResult> Index()
        {
            List<CompanySlider> companySlider = await _habanService.GetAllSlider();

            return View(companySlider);
        }
    }
}
