using Microsoft.AspNetCore.Mvc;

namespace Coffee_MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
