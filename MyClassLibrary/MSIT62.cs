using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class MSIT62
    {
        //dll是一個程式庫，可以被其他程式引用
        //const 無法引用dll更新，需要重新建置
        public const string classroom = "1802";
        //readonly 可以引用dll更新
        public static readonly string hours = "570";
    public string sayhi()
        {
            return "Hi";
        }
    }

}
