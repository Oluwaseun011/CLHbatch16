using Microsoft.AspNetCore.Mvc;
using StudentMgtApp.Dtos;
using StudentMgtApp.Repositories.Interfaces;
using StudentMgtApp.Service.Interfaces;

namespace StudentMgtApp.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
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
        public IActionResult Register(CreateRoleRequestModel asd)
        {
            _roleService.Create(asd);
            return RedirectToAction("Index", "Home");
        }
    }
}
