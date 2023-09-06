using Microsoft.AspNetCore.Mvc;
using StudentMgtApp.Dtos;
using StudentMgtApp.Service.Interfaces;

namespace StudentMgtApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterStudentRequestModel asd)
        {
            _studentService.Register(asd);
            return RedirectToAction("Index", "Home");
        }
    }
}
