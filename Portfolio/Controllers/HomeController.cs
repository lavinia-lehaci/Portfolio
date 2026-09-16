using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FileReader _fileReader;

        public HomeController(ILogger<HomeController> logger, FileReader fileReader)
        {
            _logger = logger;
            _fileReader = fileReader;
        }

        public IActionResult Index()
        {
            var workExperience = _fileReader.LoadWorkExperience();
            var education = _fileReader.LoadEducation();
            var projects = _fileReader.LoadProjects();

            var model = new HomeViewModel
            {
                WorkExperience = workExperience,
                Education = education,
                Projects = projects
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
