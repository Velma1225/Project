using Microsoft.AspNetCore.Mvc;

namespace HabanMVC.Controllers
{
    public class CompanyLoginRegisterController : Controller
    {
        public IActionResult CompanyLogin()
        {
            return View();
        }
        public IActionResult CompanyRegister()
        {
            return View();
        }
        public IActionResult CompanyRegisterInfo()
        {
            return View();
        }
        public IActionResult EmailVerification()
        {
            return View();
        }
    }
}
