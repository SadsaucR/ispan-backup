using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class ProdController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.P = $"產品id為{id}";
            return View();
        }
    }
}
