using Haban.Models;
using HabanMVC.Services.Job;
using HabanMVC.ViewModels.Job;
using HabanMVC.ViewModels.Job.Description;
using Microsoft.AspNetCore.Mvc;


namespace HabanMVC.Controllers
{
    public class JobController : Controller
    {
        private readonly ILogger<JobController> _logger;
        private readonly JobIndexViewModelService _indexViewModelService;
        private readonly JobDescriptionViewModelService _descriptionViewModelService;        

        public JobController(ILogger<JobController> logger, JobIndexViewModelService indexViewModelService, JobDescriptionViewModelService jDViewModelService)
        {
            _logger = logger;
            _indexViewModelService = indexViewModelService;
            _descriptionViewModelService = jDViewModelService;
        }
        public IActionResult Index()
        {
            var viewModel = _indexViewModelService.TransformToJobIndexViewModel();
            return View(viewModel);
        }

        public IActionResult Description(int id)
        {
            var jDViewModel = _descriptionViewModelService.GetJobById(id);
            if (jDViewModel == null)
            {
                return NotFound();
            }
            return View(jDViewModel);
        }
    }
}
