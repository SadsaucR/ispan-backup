using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class TestPartialViewController : Controller
    {
        public IActionResult Shiro()
        {
            ViewBag.S = "TestPartialView-小白";
            ViewData["Dog"] = "我是狗。 --此話來自Controller";
            return View();
        }
        public IActionResult Nanako()
        {
            ViewBag.N = "TestPartialView-娜娜子";
            return View();
        }
        public IActionResult Himawari()
        {
            ViewBag.H = "TestPartialView-小葵";
            return View();
        }
    }
}
