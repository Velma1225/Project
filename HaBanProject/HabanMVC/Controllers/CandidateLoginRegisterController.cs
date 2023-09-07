using Microsoft.AspNetCore.Mvc;

namespace HabanMVC.Controllers
{
    public class CandidateLoginRegisterController : Controller
    {
        public IActionResult CandidateLogin()
        {
            return View();
        }
        public IActionResult CandidateRegister()
        {
            return View();
        }
        public IActionResult CandidateRegisterInfo()
        {
            return View();
        }
        public IActionResult EmailVerification()
        {
            return View();
        }
    }
}
