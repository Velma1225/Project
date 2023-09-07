using Microsoft.AspNetCore.Mvc;

namespace HabanMVC.Controllers
{
    public class JobNewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JobNewStep1()
        {

            return View();
            //return View("Views/Company/JobNew/JobNewStep1.cshtml");
        }
        public IActionResult JobNewStep2()
        {
            return View();
        }
        public IActionResult JobNewStep3()
        {
            return View();
        }
        public IActionResult JobNewStep4()
        {
            return View();
        }
    }
}
