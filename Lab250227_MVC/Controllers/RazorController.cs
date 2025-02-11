using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
