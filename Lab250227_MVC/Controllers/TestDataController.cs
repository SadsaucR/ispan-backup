using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class TestDataController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.A1 = 7;
            ViewBag.A2 = "皮卡丘三小啦";
            ViewData["A3"] = "兒童節";
            TempData["A4"] = "中秋節";

            ViewData["A5"] = 5;
            TempData["A6"] = 5;
            ViewBag.DT1=DateTime.Now;
            ViewBag.DT2= DateTime.Now.ToString("yyyy-MM-dd");
            ViewBag.DT3= DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            TempData["D1"] = "端午節";
            TempData["D2"] = "萬聖節";
            return View();
        }
        public IActionResult DataCat()
        {
            return View();
        }
        public IActionResult DataDog()
        {
            return View();
        }

        public IActionResult DataSession()
        {
            return View();
        }
    }
}
