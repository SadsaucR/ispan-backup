using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Account()
        {
            ViewBag.UserName = "皮卡丘";
            ViewBag.UserSex = "F";
            ViewBag.UserAddr = "TPE";

            return View();
        }
    }
}
