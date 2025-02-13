using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class TestJSONController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // https://localhost:7292/TestJSON/ProductData
        public JsonResult ProductData()
        {


            List<Product> products_list = new List<Product>();
            Product p1 = new Product("VivoX80","25000");
            Product p2 = new Product("Iphone16", "45000");

            products_list.Add(p1);
            products_list.Add(p2);
            return Json(products_list);
        }
    }
}
