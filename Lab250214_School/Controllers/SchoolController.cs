using Lab250214_School.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab250214_School.Controllers
{
    public class SchoolController : Controller
    {
            List<Student> students = new List<Student>
                {
                    new Student { sID = 1, sName = "Pikachu", Chinese = 100, English = 90, Math = 60 },
                    new Student { sID = 12, sName = "Mary", Chinese = 92, English = 82, Math = 60 },
                    new Student { sID = 23, sName = "Lisa", Chinese = 98, English = 91, Math = 94 },
                    new Student { sID = 34, sName = "John", Chinese = 63, English = 85, Math = 55 },
                    new Student { sID = 45, sName = "David", Chinese = 59, English = 77, Math = 82 }
                };
        public IActionResult Index()
        {
            //A3
            //使用foreach 將清單中的類別資料做加總
            foreach (var item in students)
            {
                item.Total = item.Chinese + item.English + item.Math;
            }
            return View(students);
        }

        //-----------------------------------------------------------------

        //問題1： 為什麼看不到 Edit頁面？
        //答案1：  Controller中不存在方法並設定回傳Edit View，因此無法顯示Edit頁面。


        //問題2： 如何修正程式碼？ 我期望能夠看到 Edit頁面
        //答案2：Controller中新增Edit方法並設定回傳View。

        public IActionResult Edit(string SID)
        {
            Student tmp = new Student();


            //foreach 寫法
            //foreach (var item in students)
            //{
            //    if (item.sID.ToString() == SID)
            //    {
            //        tmp = item;
            //        break;
            //    }
            //}
            //return View(tmp);

            //LINQ 查詢語法
            //為甚麼要使用First()轉型? 為了將Iemuerable(多數資料)轉型為Student(單筆資料)
            //tmp = (from s1 in students
            //      where s1.sID.ToString() == SID
            //      select s1).First();
            //return View(tmp);


            //LINQ 方法語法
            tmp = students.Where(s1 => s1.sID.ToString() == SID).First();
            return View(tmp);
        }


    }


}
