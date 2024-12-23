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
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入單價:");
            int b = Convert.ToInt32(Console.ReadLine());
            //discount 紀錄打折參數
            double discount = (a >= 20) ? 0.9 : discount = (a >= 10) ? 0.95 : 10;
            Console.WriteLine("折扣{0}折，總價格為{1:0}", (a >= 20) ? "9" : (a >= 10) ? "95" : "無打", discount * a * b);
        }

        //P16_Net折扣

        static void P16_Netdisc()
        {
            int a = 399;
            Console.Write("輸入衣服購買數量>>>");
            int qty = Convert.ToInt32(Console.ReadLine());
            int gate = 1500;
            int total = a * qty;
            double discount = (total >= gate) ? 0.79 : 1;
            if (discount < 1)
            {
                Console.WriteLine("總金額為:{0:C0},超過{1}，折扣後為{2:0}", total, gate, total * discount);
            }
            else
            {
                Console.WriteLine("總金額為:{0:C0},未達{1}，還差{2:0}", total, gate, gate - total);
            }
        }

        //P17 Switch敘述
        static void P17_switch()
        {
            int a = 30;
            string b = "";
            switch (a)
            {
                case 10:
                    b = "10";
                    break;
                case 20:
                    b = "20";
                    break;
                default:
                    b = "無";
                    break;
            }
            Console.Write("{0}", b);
        }
        //P18 switch 應用
        static void P18_switch_test()
        {
            Console.Write("請輸入年資:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("請輸入月薪:");
            double m = Convert.ToDouble(Console.ReadLine());
            double reward = (y >= 6) ? 5 : (y >= 3 && y < 6) ? 3 : (y >= 1 && y < 3) ? 1 : 0;
            string rst = string.Empty;
            switch (reward)
            {
                case 5:
                    rst = "超過六年";
                    break;
                case 3:
                    rst = "達三年未滿六年";
                    break;
                case 1:
                    rst = "達一年未滿三年";
                    break;
                default:
                    rst = "你個菜B不滿一年";
                    break;
            }
            Console.WriteLine("試算的年資為{0}，月薪為{1:C0}", y, m);
            Console.WriteLine("{0}，發放獎金{1}個月:{2:C0}", rst, reward, m * reward);
        }
        //P19 For迴圈

        static void P19_forloop()
        {
            int sum = 0;
            int len = 100;
            for (int i = 0; i <= len; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.Write(" {0} ", i);
                    if (i < +len - 1)
                    {
                        Console.Write("+");
                    }
                }
            }
            Console.WriteLine("= {0}", sum);
        }

        //P20 While迴圈

        static void P20_whileloop()
        {
            int i = 0;
            int sum = 0;
            int len = 100;
            while (i <= len)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.Write(" {0} ", i);
                    if (i < +len - 1)
                    {
                        Console.Write("+");
                    }
                }
                i++;
            }
            Console.WriteLine("= {0}", sum);
        }

        //P21 水仙花
        static void P21_flower()
        {
            int total;
            int i = 100;
            Console.Write("在100~999之間符合的數值有:");
            while (i <= 999)
            {
                total = i;
                int num1 = i / 100;
                int num2 = (i / 10) % 10;
                int num3 = i % 10;
                if (total == Math.Pow(num1, 3) + (Math.Pow(num2, 3) + Math.Pow(num3, 3)))
                {
                    Console.Write(i + " ");
                }
                i++;
            }
        }
        //P22 陣列
        static void P22_array()
        {
            String[] arr = { "Apple", "Banana" };
            string[] arr2 = new string[2];
            string[] arr3 = new string[2] { "Apple2", "Banana2" };

            Console.WriteLine(arr);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);

            Console.WriteLine(arr2[0]); //arr2為空陣列 **空陣列不等於null
            Console.WriteLine(arr2[1]);

            Console.WriteLine(arr3[0]);
            Console.WriteLine(arr3[1]);

            arr2[1] = "Orange";
            arr2[0] = "Slut";
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[1]);

        }

        //P23 陣列+迴圈
        static void P23_arrayloop()
        {
            string[] arr = { "Screen", "Keyboard", "Mouse", "Microphone" };

            for (int i = 0; i < 4; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //foreach (string str in arr)
            //{
            //    Console.Write($"{str} ");
            //}
            string tmp = string.Join(" ", arr);
            Console.WriteLine(tmp);
        }

        //P24數字陣列

        static void P24_intarray()
        {
            int[] arr = { 71, 81, 91 };
            int[] arr2 = new int[3];
            int[] arr3 = new int[3] { 72, 82, 92 };

            Console.WriteLine(arr);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr2[2]);
            Console.WriteLine(arr3[2]);

            arr[0] = 100;
            arr2[0] = 100;

            string apple = string.Join("#", arr);
            string bee = string.Join("@", arr);
            string cat = string.Join("*", arr);
            Console.WriteLine(apple);
            Console.WriteLine(bee);
            Console.WriteLine(cat);
        }

        //P25 數字陣列方法

        static void P25_intarray_method()
        {
            int[] arr = { 10, 25, 12, 23 };
            string lst = string.Join(" ", arr);
            Console.WriteLine(lst);

            double avg = arr.Average();
            Console.WriteLine(avg);

            int max = arr.Max();
            Console.WriteLine(max);

            int min = arr.Min();
            Console.WriteLine(min);

            Array.Sort(arr);
            lst = string.Join(" ", arr);
            Console.WriteLine(lst);
        }

        //P26 陣列應用

        static void P26_arraytest()
        {
            int len = 10;
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = i + 1;
                Console.WriteLine("陣列內容:ar[{0}]={1}", i, arr[i]);
            }
            Console.WriteLine("----------反轉----------");
            for (int r = len - 1; r >= 0; r--)
            {
                Console.WriteLine("陣列內容:ar[{0}]={1}", r, arr[r]);
            }
        }

        //P27 陣列input
        static void P27_arraystored()
        {
            int[] arr = new int[100];
            Console.Write("請輸入一個數值:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------");
            Console.WriteLine("產生結果");
            for (int i = 0; i < input; i++)
            {
                if (i > 1)
                {
                    arr[i] = arr[i - 2] + arr[i - 1];
                }
                else
                {
                    arr[i] = 1;
                }
                Console.WriteLine("陣列[{0}] 存放數字 {1}", i, arr[i]);
            }
            Console.WriteLine("------------------");
        }

        //P27 平均溫度
        static void P28_temper()
        {
            int[] month = new int[12];
            int[] temp = { 26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18 };
            for (int i = 1; i <= 12; i++)
            {
                Console.Write("{0}月 ", i.ToString().PadLeft(2, '0'));
            }
            // \n換行符號 
            Console.WriteLine("\n-----------------------------------------------------------");
            int total = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("{0}度 ", temp[i].ToString().PadLeft(2, '0'));
                total += temp[i];
            }
            double avg = (double)total / temp.Length;
            Console.Write("\n平均溫度為:{0:F1}", avg);
        }

        //P29 二維陣列
        static void P29_2darray()
        {
            string[,] arr = new string[2, 5];
            arr[0, 0] = "G0";
            arr[0, 1] = "G1";
            arr[0, 2] = "G2";
            arr[0, 3] = "G3";
            arr[0, 4] = "G4";

            arr[1, 0] = "T0";
            arr[1, 1] = "T1";
            arr[1, 2] = "T2";
            arr[1, 3] = "T3";
            arr[1, 4] = "T4";
            Console.WriteLine("arr");

            //print  array | using for loop
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.Write("\n");
            }
            foreach (string item in arr)
            {
                Console.Write("{0} ", item);
            }
        }

        //P30 3darray

        static void P30_3darray()
        {
            int[,,] arr = new int[2, 5, 9];
            Console.WriteLine(arr.Length); //90 2x5x9
            Console.WriteLine(arr.Rank); //3 總和為3維陣列
            Console.WriteLine(arr.GetLength(0)); //2
            Console.WriteLine(arr.GetLength(1)); //5
            Console.WriteLine(arr.GetLength(2)); //9
        }

        //P31 不規則陣列
        static void P31_irregulararray()
        {
            string[][] arr = new string[2][];
            arr[0] = new string[4];
            arr[0][0] = "D1";
            arr[0][1] = "D2";
            arr[0][2] = "D3";
            arr[0][3] = "D4";

            arr[1] = new string[3];
            arr[1][0] = "P1";
            arr[1][1] = "P2";
            arr[1][2] = "P3";

            for(int i=0; i<arr.Length ;i++)
            {
                for(int j = 0; j < arr[i].Length;j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }
        }
       
    //交錯數組array[2][]有分內外層

    //array.Length: 外層array的長度:2層(array[0], array[1])

    //array[0].Length跟array[1].Length 才能套用相乘的那種算法

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
            //P15_tricald_test();
            //P16_Netdisc();
            //P17_switch();
            //P18_switch_test();
            //P19_forloop();
            // P20_whileloop();
            //P21_flower();
            //P22_array();
            //P23_arrayloop();
            //P24_intarray();
            //P25_intarray_method();
            //P26_arraytest();
            //P27_arraystored();
            //P28_temper();
            //P29_2darray();
            //P30_3darray();
            P31_irregulararray();





            Console.ReadKey(); //此程式將在完成時暫停
        }
    }
}
