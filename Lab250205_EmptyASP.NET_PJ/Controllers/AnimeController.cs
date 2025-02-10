using Microsoft.AspNetCore.Mvc;

namespace Lab250205_EmptyASP.NET_PJ.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pokemon()
        {
            return View();
        }

        public IActionResult Doraemon()
        {
            return View();
        }
    }
}
