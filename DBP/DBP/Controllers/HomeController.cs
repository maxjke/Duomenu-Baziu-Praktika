using DBP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BL.Persons;
using DAL.Models;

namespace DBP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository studRepo;

        public HomeController(ILogger<HomeController> logger, IStudentRepository studRepo)
        {
            _logger = logger;
            this.studRepo = studRepo;
        }

        [HttpPost]
        [Route("/create-student")]
        public async Task<IActionResult> CreateStudent(StudentViewModel student)
        {
            var studentModel = new Student()
            {
                ContactInfo = new ContactInfo()
                {
                    Address = student.Address,
                    Zipcode = student.Zipcode,
                    Email = student.Email,
                    City = student.City,
                    Name = student.Name,
                    LastName = student.LastName,
                    PhoneNumber = student.PhoneNumber,
                    Country = student.Country
                }
            };


           await studRepo.Create(studentModel);

           return  View("EditStudents");
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

        public IActionResult Lector()
        {
            return View();
        }

        public IActionResult Student()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult CourseRating()
        {
            return View();
        }

        public IActionResult ReviewRatings()
        {
            return View();
        }

        public IActionResult AddStudentToAGroup()
        {
            return View();
        }

        public IActionResult StudentBoughtCourses()
        {
            return View();
        }

        public IActionResult Course_AT()
        {
            return View();
        }

        public IActionResult Course_WEB()
        {
            return View();
        }

        public IActionResult Course_UIUX()
        {
            return View();
        }

        public IActionResult Course_DAPY()
        {
            return View();
        }

        public IActionResult Course_WEB2()
        {
            return View();
        }

        public IActionResult Course_JS()
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
