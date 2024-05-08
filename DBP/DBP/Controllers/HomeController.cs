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
        private readonly ITeacherRepository teacherRepo;
        private readonly ICompanyRepository companyRepo;
        private readonly ICourseRepository courseRepo;
        public HomeController(ILogger<HomeController> logger, IStudentRepository studRepo, ITeacherRepository teacherRepo, ICompanyRepository companyRepo, ICourseRepository courseRepo)
        {
            _logger = logger;
            this.studRepo = studRepo;
            this.teacherRepo = teacherRepo;
            this.companyRepo = companyRepo;
            this.courseRepo = courseRepo;
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


        [HttpPost]
        [Route("/update-student")]
        public async Task<IActionResult> UpdateStudent(StudentViewModel model)
        {
            var student = await studRepo.Get(model.Id);


            await studRepo.Update(new ContactInfo()
            {
                Id = (int)student.contactinfo_id,
                Name = model.Name,
                Address = model.Address,
                City = model.City,
                Country = model.Country,
                Zipcode = model.Zipcode,
                Email = model.Email,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber
            });

            return Redirect("/Home/EditStudents");
        }


        [HttpPost]
        [Route("/create-teacher")]
        public async Task <IActionResult> CreateTeacher(TeacherViewModel teacher)
        {
            var teacherModel = new Teacher()
            {
                ContactInfo = new ContactInfo()
                {
                    Address = teacher.Address,
                    Zipcode = teacher.Zipcode,
                    Email = teacher.Email,
                    City = teacher.City,
                    Name = teacher.Name,
                    LastName = teacher.LastName,
                    PhoneNumber = teacher.PhoneNumber,
                    Country = teacher.Country

                }
            };
            await teacherRepo.Create(teacherModel);

            return View("EditLecturers");
        }

        [HttpPost]
        [Route("/create-company")]
        public async Task<IActionResult> CreateCompany(CompanyViewModel company)
        {
            var companyModel = new Company()
            {
                CompanyName = company.CompanyName,
                CompanyDescription = company.CompanyDescription
            };
            await companyRepo.Create(companyModel);

            return View("EditCompanies");
        }

        [HttpPost]
        [Route("/create-course")]
        public async Task<IActionResult> CreateCourse(CourseViewModel course)
        {
            var courseModel = new Course()
            {
                CourseName = course.CourseName,
                Duration = course.Duration,
                Price = course.Price,

            };
            await courseRepo.Create(courseModel,course.TeacherName);

            return View("EditCourses");
        }
        [HttpPost]
        [Route("/update-lecturer")]
        public async Task<IActionResult> UpdateLecturer(TeacherViewModel model)
        {
            var teacher = await teacherRepo.Get(model.Id);


            await studRepo.Update(new ContactInfo()
            {
                Id = (int)teacher.contactinfo_id,
                Name = model.Name,
                Address = model.Address,
                City = model.City,
                Country = model.Country,
                Zipcode = model.Zipcode,
                Email = model.Email,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber
            });

            return Redirect("/Home/EditStudents");
        }

        [HttpDelete]
        [Route("/delete-company")]
        public async Task<IActionResult> DeleteCompany()
        {
            await companyRepo.Delete();
            return View("EditCompanies");
        }

        [HttpDelete]
        [Route("/delete-lecturer")]
        public async Task<IActionResult> DeleteLecturer()
        {
            return View("EditLecturers");
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

        public async Task<IActionResult> EditStudents()
        {
            var x = await studRepo.FindAll();
            return View("EditStudents", x);
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
