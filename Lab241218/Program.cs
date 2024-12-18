using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab241218
{
    internal class Program
    {
        //P1 主控台介紹
        static void P1_console()
        {
            Console.WriteLine("PX");
            Console.WriteLine("123");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();

            Console.Write(true);
            Console.Write("Carreful");

            //Console.Clear();
        }

        //P2 字串串接
        static void P2_printstring()
        {
            Console.Clear();

            //串接法 
            string s1 = "Jasper";
            Console.WriteLine("Hello " + s1 + "!!!!");
            //呼叫法
            Console.WriteLine($"Hello {s1}!!!! ");
            //物件傳入法
            Console.WriteLine("Hello {0}{1}", s1, "!!!!");
        }
        //P3 宣告
        static void P3_define()
        { 
            //使用關鍵字"string"去宣告，原為"Ststem.String"
            Console.Clear();
            string A = "JP1";
            String B = "JP2";
            System.String C = "JP3";
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(A.GetType());
            Console.WriteLine(B.GetType());
            Console.WriteLine(C.GetType());
        }

        //P4 整數

        static void P4_int()
        {
            Console.Clear();
            //int i1 = 123;
            //System.Int32 i2 = 456;
            int imin = int.MinValue;
            int imax= int.MaxValue;
            Console.WriteLine("int的範圍介於"+imin+"和"+imax+"之間");
        }

        //P5 整數運算

        static void P5_intcalc()
        {
            //Console.Clear();
            //注意!!!  C# 中運算不會自動轉換資料型態，需額外轉換。
            int x = 10;
            int y = 3;
            Console.WriteLine($"x/y={ (float)x/y}");
        }

        //void:此函數沒有回傳值，函數將無法return值
        //按下F5時，將執行Main中的動作，作為Program中的主程式。
        static void Main()
        {
            P1_console();
            P2_printstring();
            P3_define();
            P4_int();
            P5_intcalc();
            Console.ReadKey();
        }
    }
}
