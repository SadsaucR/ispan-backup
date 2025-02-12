using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class TestViewController : Controller
    {
        public IActionResult Index()
        {
            return View("Index","爬卡丘");
        }
        public IActionResult Bob()
        {
            return View();
            // "Pikachu.cshtml" 不行
            // "/Views/Home/Index.cshtml" 跑到HOME
            

        }
        public IActionResult Olaf()
        {
            ViewBag.Olaf = "雪保";
            return View();
        }
        public IActionResult Elsa()
        {
            return RedirectToAction(controllerName: "TestView", actionName: "Olaf");
        }

        //        【請依序修改 函式 **Elsa** 的回傳方式，並說明為什麼得到這樣的結果】

        //練習： return View("Olaf");
        //    執行結果： 跳轉至Olaf頁，但未經過Action，因此Action傳送的資料無法收到。


        //練習： return Redirect("~/TestView/Olaf");
        //    執行結果： 跳轉至Olaf頁，URL導向至Olaf，因此會經過Action，此方式適合連到外部網站。


        //練習： return RedirectToAction("Olaf", "TestView");
        //    執行結果： 跳轉至Olaf頁，重新導向至Olaf，因此會經過Action 


        //練習： return RedirectToAction(controllerName:"TestView", actionName:"Olaf");
        //    執行結果： 跳轉至Olaf頁，重新導向至Olaf，因此會經過Action (RedirectToAction 另外一種語法)

        //ActionName 可以替換原本的ActionName在URL上顯示的名稱，將原本Action隱藏起來，爾虞我詐是三國。
        [ActionName("Reichu")]
        public IActionResult Pikachu()
        {
            return View("Pikachu");
        }

        [ActionName("Title")]
        public IActionResult Rickroll()
        {
            return Redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
