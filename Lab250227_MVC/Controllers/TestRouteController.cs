using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class TestRouteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Mouse(string apple, string bee, string id)
        {
            string data = $"米老鼠 id:{id}  apple:{apple}  bee:{bee}";
            return data;
        }

        //    問題： 若URL 為 http://localhost:XXXX/TestRoute/Mouse/123
        //    則回傳字串中的 id 、 apple 、 bee 三者各自會呈現什麼？ 


        //答案："123" 、""、""

        //-----------------------------------------
        //問題： 若URL 為 http://localhost:XXXX/TestRoute/Mouse/123/456
        //    則回傳字串中的 id 、 apple 、 bee 三者各自會呈現什麼？ 


        //答案：""、"123"、"456"


        //-----------------------------------------
        //問題： 如果把 MouseA 和 MouseB 執行的順序交換，是否還會得到相同的測試結果？


        //答案：YES

        //-----------------------------------------
        //問題： 為什麼 id 、 apple 、 bee 這三者不能同時有值？


        //答案：route 並未設定出含有id、apple、bee的方法

        public string Duck()
        {
            string? x = HttpContext.Request.Query["cat"];
            string? y = HttpContext.Request.Query["dog"];
            return "唐老鴨" + x + "和" + y;
        }

        public IActionResult Rabbit(string id)
        {
            ViewBag.R = $"兔八哥 id:{id}";
            return View();
        }

        public IActionResult Prod(string id)
        {
            ViewBag.P = $"產品id為:{id}";
            return View();
        }

    }
}
