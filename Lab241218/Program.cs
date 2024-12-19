﻿using System;
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

        //P2 印出
        static void P2_print()
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
            int imax = int.MaxValue;
            Console.WriteLine("int的範圍介於" + imin + "和" + imax + "之間");
        }

        //P5 整數運算

        static void P5_intcalc()
        {
            Console.Clear();
            //注意!!!  C# 中運算不會自動轉換資料型態，需額外轉換。
            int x = 10;
            int y = 3;
            Console.WriteLine($"x/y={x / y}");
            Console.WriteLine($"x/y={(float)x / y}");
        }

        //P6 浮點數
        static void P6_float()
        {
            Console.Clear();
            float x = 1.23F;
            double y = 1.23;
            decimal z = 1.23M;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            float f1 = 1.0F;
            float f2 = 6.0F;
            float f3 = f1 / f2;
            Console.WriteLine(f3);
            double d1 = 1.0;
            double d2 = 6.0;
            double d3 = d1 / d2;
            Console.WriteLine(d3);
            decimal D1 = 1.0M;
            decimal D2 = 6.0M;
            decimal D3 = D1 / D2;
            Console.WriteLine(D3);
        }

        //P7 格式化字串
        static void P7_format()
        {
            Console.Clear();
            Console.WriteLine("P3");
            double x = 123.123;
            //ToString("C2") C:貨幣格式 2:小數點後第二位 0:不秀小數點
            Console.WriteLine(x.ToString("C2"));
            Console.WriteLine("Before:X={0:C} After:X={1:C5}", x, x);

            //N:數字(帶有三位一撇)
            int y = 1234567890;
            Console.WriteLine(y.ToString("N"));
            Console.WriteLine(y.ToString("N0"));

            //F:固定點
            double z = 0.123456;
            Console.WriteLine(z.ToString("F2"));
            Console.WriteLine(z.ToString("F0"));
            Console.WriteLine(z.ToString("F8"));
        }

        //P8 字串方法
        static void P8_stringfunc()
        {
            Console.Clear();
            string s1 = "HELLO          ";
            //Trim 頭尾去空白 可以看到HELLO後面的空白未被算入長度
            //IndexOf 搜尋字元出現的位置及初遇位置
            //Substring 擷取字串(起始位置,擷取字數)
            //PadLeft 補足指定的長度
            //**字元使用'單引號'敘述
            Console.WriteLine((s1.Trim()).Length);
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());
            Console.WriteLine(s1.IndexOf("L"));
            Console.WriteLine(s1.Substring(0, 4));
            Console.WriteLine(s1.PadLeft(20, '0'));
        }
        //P9 空字串及特殊符號

        static void P9_nullstr_escapech()
        {
            //設為null不等於空字串
            Console.Clear();
            string a = "";
            string b = null; //**別用這個
            string c = string.Empty;

            Console.WriteLine(a == b);
            Console.WriteLine(b == c);
            Console.WriteLine(c == a);

            //跳脫符號 反斜線(\) or 小老鼠(@)
            string d1 = "D:\\Lab241218";
            string d2 = @"D:\Lab241218";
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            //同時使用$呼叫法加上跳脫符號(\)，可同時使用
            string me = "jasper";
            //$@包含呼叫法、特殊符號
            string strwithsp = $@"HELLO \{me}\";
            Console.WriteLine(strwithsp);
        }

        //P10 主控台讀取

        static void P10_consoleLoad()
        {
            Console.Clear();
            Console.WriteLine("P10");
            string sa = Console.ReadLine();
            //讀取使用者資料夾


            int a = Console.Read();
            Console.WriteLine(a);
            Console.WriteLine("P10-結束");

        }

        //P11 臺斤轉換 使用者輸入ReadLine + 轉型應用convert
        static void P11_taijin()
        {
            Console.Clear();
            Console.Write("請輸入數值(公斤)>>");
            string kg = Console.ReadLine();
            Console.WriteLine("你輸入{0}公斤", kg);
            Console.Write("轉換為臺斤為>>");
            float vkg = Convert.ToSingle(kg);
            Console.WriteLine("{0}臺斤!!!!", vkg * 0.6);
        }
        //P12 IF敘述
        static void P12_IF()
        {
            Console.Clear();
            //事先將str格式轉換為int格式
            Console.Write("清輸入第一個數值>>");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("清輸入第二個數值>>");
            int p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("你輸入了{0},{1}", p1, p2);
            Console.WriteLine("{0}>{1}={2}", p1, p2, p1 > p2);
            Console.WriteLine("{0}<{1}={2}", p1, p2, p1 < p2);
            if (p1 > p2)
            {
                Console.WriteLine("{0}大於{1}", p1, p2);
            }
            else if (p1 < p2)
            {
                Console.WriteLine("{0}小於{1}", p1, p2);
            }
            else
            {
                Console.WriteLine("{0}等於{1}", p1, p2);
            }
        }

        //P13 比大小test

        static void P13_IF_test()
        {
            Console.Write("請輸入第一個數值>>");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入第二個數值>>");
            int b = Convert.ToInt32(Console.ReadLine());

            string result = string.Empty;
            if (a % b == 0 || b % a == 0)
            {
                result = "是倍數";
                Console.WriteLine("第一個數字:{0}，第二個數字:{1}==>{2}", a, b, result);
            }
            else
            {
                result = "不是倍數";
                Console.WriteLine("第一個數字:{0}，第二個數字:{1}==>{2}", a, b, result);
            }

        }

        //P14 三元運算
        static void P14_tricalc()
        {
            Console.WriteLine("P14");
            string food = string.Empty;
            int weather = 20;
            if (weather < 15)
            {
                food = "Hotpot";
            }
            else
            {
                food = "Mcdonald";
            }
            Console.WriteLine(food);

            string food2 = (weather < 15) ? "吃火鍋" : "麥當勞";
            Console.WriteLine(food2);

            Console.WriteLine("我今天晚上想要吃{0}", weather < 15 ? "火鍋" : "麥當勞");

        }

        //P15 三元運算test

        static void P15_tricald_test()
        {
            Console.Write("請輸入數量:");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入單價:");
            int b = Convert.ToInt32(Console.ReadLine());
            double discount;
            Console.Write("折扣{0}折，總金額為:{1}",(discount= (a >= 20) ? 9.0 : 9.5),(double)(0.1*discount*a*b));
        }
        //void:此函數沒有回傳值，函數將無法return值
        //按下F5時，將執行Main中的動作，作為Program中的主程式。
        static void Main()
        {
            //P1_console();
            //P2_print();
            //P3_define();
            //P4_int();
            //P5_intcalc();
            //P6_float();
            //P7_format();
            //P8_stringfunc();
            //P9_nullstr_escapech();
            //P10_consoleLoad();
            //P11_taijin();
            //P12_IF();
            //P13_IF_test();
            //P14_tricalc();
            P15_tricald_test();

            Console.ReadKey(); //此程式將在完成時暫停
        }
    }
}