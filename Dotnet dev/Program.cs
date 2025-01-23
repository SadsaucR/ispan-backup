using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_dev
{
    internal class Program
    {
        static void P1_enum()
        {
            Console.WriteLine("\r\n這裡是P1");
            //enum -> 可以寫在class的內部或外部
            //enum裡面有甚麼東西
            //enum -> Key 與 Value 的組合
            //enum-> 透過資料取得數字(將列舉轉型ˊ)
            //enum-> 透過數字取得資料(將數字轉型)

            Console.WriteLine(fruit.banana); //banana
            Console.WriteLine((int)fruit.banana); //int parse banana => 200
            Console.WriteLine((fruit)200); //enum parse 200 => banana
            Console.WriteLine((demo.animal)0); //class.enum parse 0 => Cat
            Console.WriteLine((int)demo.animal.Elephant); //int parse Elephant => 2
        }

        static void P2_parameter()
        {
            //參數 parameter
            //引數 argument
            //Q:這兩個英文單字是不是關鍵字? A:不是
            //Q:引數是參數嗎? A:是


            //例1:
            Console.WriteLine("Hello World!");
            //字串Hello World!是參數，傳入Console.WriteLine這個方法
        }
        static void P3_interface()
        {
            //Q;介面是什麼? A:介面是一個規格，定義一個規格，讓其他class去實作
            //Q:介面可以有甚麼東西? A:變數 屬性 方法 事件
            //Q:實作介面的時候一定要公開嗎? A:是

            CoCo s1 = new CoCo();
            Console.WriteLine(s1.Bubble);
            Console.WriteLine(s1.Tea);

            Kebuke s2 = new Kebuke();
            Console.WriteLine(s2.Bubble);
            Console.WriteLine(s2.Tea);

            IBubbleTea s3 = new CoCo();
            Console.WriteLine(s3.Bubble);
            Console.WriteLine(s3.Tea);

            IBubbleTea s4 = new Kebuke();
            Console.WriteLine(s4.Bubble);
            Console.WriteLine(s4.Tea);

            //IEnumerable<T> 也是介面，後面接 LINQ 查詢語法
        }

        static void P4_intinit()
        {
            Test t1 = new Test();
        }

        static void Main(string[] args)
        {
            //P1_enum();
            //P2_parameter();
            //P3_interface();
            P4_intinit();

        }
    }
}
