using Microsoft.AspNetCore.Mvc;

namespace HabanMVC.Controllers
{
    public class JobEditController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult JobEditStep1()
        {

            return View();
            //return View("Views/Company/JobEdit/JobEditStep1.cshtml");
        }
        public IActionResult JobEditStep2()
        {
            return View();
        }
        public IActionResult JobEditStep3()
        {
            return View();
        }
        public IActionResult JobEditStep4()
        {
            return View();
        }
    }
}
