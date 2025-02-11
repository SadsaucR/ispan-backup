using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.AspNetCore.Mvc;

namespace Lab250227_MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Account()
        {
            ViewBag.UserName = "皮卡丘";
            ViewBag.UserSex = "F";
            ViewBag.UserAddr = "TPE";
            return View();
        }

        public IActionResult AccountV2()
        {
            //new Account Data 使用Class 方式
            string UserName = "小智";
            string UserSex = "M";
            string UserAddr = "TPE";

            AccountData m1 = new AccountData(UserName,UserSex,UserAddr);
            //ViewBag整個Class
            ViewBag.User = m1;

            //ViewBag 每個Class屬性
            ViewBag.UserName = UserName;
            ViewBag.UserSex= UserSex;
            ViewBag.UserAddr = UserAddr;

            return View();
    }
}

public class Account
{
    public string UserName { get; set; }
    public string UserSex { get; set; }
    public string UserAddr { get; set; }
}
}
