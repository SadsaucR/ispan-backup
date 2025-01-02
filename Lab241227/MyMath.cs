using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab241227
{
    //定義屬性
    partial class MyMath
    {
        public int x;
        public int y;
    }

    //定義函數
    partial class MyMath
    {
        public int Add()
        {
            return x+y;
        }

        public int Add(int mx,int my )
        {
            return mx + my;
        }

        public int Add(string mx, string my)
        {
            return Convert.ToInt32( mx) + Convert.ToInt32( my);
        }

    }
}
