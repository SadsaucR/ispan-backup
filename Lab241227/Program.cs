using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241227
{
    internal class Program
    {

        //P1 partial
        static void P1_partial()
        {
            MyMath pika = new MyMath();
            pika.x = 100;
            pika.y = 100;
            int temp = pika.Add();
            int temp2 = pika.Add(101, 201);
            int temp3 = pika.Add("10", "20");
            Console.WriteLine(temp);
            Console.WriteLine(temp2);
            Console.WriteLine(temp3);
        }

        //P2 屬性設定
        //重點!!:屬性才有{get; set;}

        static void P2_attribute()
        {
            Member m1 = new Member();
            m1.MemberName = "粥劫輪";
            m1.MemberAge = 44;
            Member m2 = new Member("蟑會面");

            m1.QueryMember();
            m1.Login();
            m1.Shopping();
        }


        //P3繼承
        //繼承用法 新cls : 舊cls (於class中設定)
        //繼承的規則:如果引用(空)建構子函數，帶入父Class(空)建構子函數。
        //如建構子不為空，

        static void P3_inheritance()
        {
            Phone V80= new Phone("VivoX80 Pro","天空藍",512);
            Phone P6P = new Phone("Google Pixel 6 Pro", "曜石黑", 256);
            iPhone IP14 = new iPhone();
            amaPhone N31 = new amaPhone("台中","NOVA","Nokia 3310","金剛黑",16);

            Console.WriteLine("-----------------------分隔線---------------------------");
            V80.Call();
            P6P.Capture();
            P6P.OKGoogle();
            N31.OKGoogle();
        }

        //P4 列舉型態
        //列舉資料型態為特定資料型態，一個數字配一份資料，Ex.週期表(星期三-->3)
        static void P4_enum()
        {
            Console.BackgroundColor = ConsoleColor.Red;

            DateTime dt = DateTime.Now;
            DayOfWeek dow = dt.DayOfWeek;
            int idow = (int)dow;
            Console.WriteLine(idow);
            Console.WriteLine((DayOfWeek)idow);
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("WORKING~~");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("LAST DAY WORKING~!~!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("HOLIDAY@!@!");
                    break;
            }
        }
        //P5 列舉應用
        //enum宣告位置:可以在Class之外
        static void P5_enum_using()
        {
            List<string> list = new List<string>();
            list.Add("bulb");
            list.Add("ivy");
            list.Add("Venu");

            string d0 = list[(int)Pokemon.PokeID.venu];
            Console.WriteLine(d0);
        }

        static void Main()
        {
            //P1_partial();
            //P2_attribute();
            //P3_inheritance();
            //P4_enum();
            P5_enum_using();
        }
    }
}
