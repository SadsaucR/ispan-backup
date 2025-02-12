using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class TestJSONController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ProductData()
        {
            List<Product> products_list = new List<Product>();
            Product p1 = new Product("手機","25000");
            return Json(p1);
        }
    }
}
