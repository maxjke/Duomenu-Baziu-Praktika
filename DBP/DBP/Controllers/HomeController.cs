using DBP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DBP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CareerCenter()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult CoursesForCompanies()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult EditStudents()
        {
            return View();
        }

        public IActionResult EditLecturers()
        {
            return View();
        }

        public IActionResult EditCompanies()
        {
            return View();
        }

        public IActionResult EditCourses()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
