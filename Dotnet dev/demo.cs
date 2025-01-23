using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_dev
{
    enum fruit
    {
        apple = 100,
        banana = 200,
        cherry = 300
    }
    class demo
    {
        public enum animal
        {
            Cat = 0,
            Dog = 1,
            Elephant = 2
        }

    }
    public interface IBubbleTea
    {
        //變數 屬性 方法 事件
        string Bubble { get; }

        string Tea { get; }

    }

    class CoCo : IBubbleTea
    {
        public string Bubble { get { return "白玉珍奶"; } }
        public string Tea { get {return "錫蘭紅茶"; } }
    }

    class Kebuke : IBubbleTea
    {
        public string Bubble { get { return "椰果奶茶"; } }
        public string Tea { get { return "大吉嶺紅茶"; } }
    }

    class Test
    {
        int xa;
        public Test()
        {
            Console.WriteLine("我在CLASS裡面");
            Console.WriteLine(xa);
        }
    }

}
