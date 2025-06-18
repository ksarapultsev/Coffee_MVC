using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_MVC.Controllers
{
    [Authorize(Roles="Administrator")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            var listUsers = new List<string>();
            return View(listUsers);
        }
    }
}
