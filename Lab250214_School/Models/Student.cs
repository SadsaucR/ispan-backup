using System.ComponentModel.DataAnnotations;

namespace Lab250214_School.Models
{
    public class Student
    {
        //A4
        //A5 如果未輸入[Display(Name="xxx")] 則顯示屬性名稱
        [Display(Name = "我自己亂亂改的不要理我")]
        public int sID { get; set; }
        [Display(Name = "姓名")]
        public string? sName { get; set; }
        [Display(Name = "國文")]
        public int Chinese { get; set; }
        [Display(Name = "英文")]
        public int English { get; set; }
        [Display(Name = "數學")]
        public int Math { get; set; }
        [Display(Name = "總分")]

        public int Total { get; set;} 

        //A1
        //public int Total { get { return Chinese + English + Math; } }
    }


    //問題1：首頁跑出來的總成績為 0 為什麼？
    //答案1：沒有設定總分的屬性，因此未帶出總分資料。在類別設定中套用加總的屬性。


    //問題2：總成績 應不應該 記錄在資料庫中？
    //答案2：不需要另外紀錄。此為加總成績，存放在資料庫中浪費空間。


    //問題3：假設總成績沒有記錄在資料庫，該如何顯示總成績？
    //答案3：在Controller中使用foreach 將清單中的類別資料(item)做加總，並設定至Student.Total屬性中。


    //-----------------------------------------------------------------


    //問題4：Student.cs 的每一個屬性上方有[Display(Name = "XXX")] ，能不能修改？
    //答案4：可以修改。


    //問題5：若修改成功，影響到哪一個畫面？
    //答案5：Index頁面。


    //問題6：若刪除[Display(Name = "XXX")] ， 專案是否會無法運行？
    //答案6：可以執行，如果未輸入[Display(Name="xxx")] 會顯示屬性名稱。


    //問題7：若刪除後專案可以正常運行，是否刪除比較好？
    //答案7：不建議刪除，可以增加程式碼的可讀性。

}
