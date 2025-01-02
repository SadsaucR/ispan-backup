using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241227
{
    //attribute
    internal class Member
    {
        private int _age;

        private bool isLogin=false;
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public int MemberAge { get {return _age; } set { _age = (value > 18) ? 18 : value; } }
    
    //func
    public Member()
        {
        }
    public Member(string _MemberName)
        {
            Console.WriteLine();
            MemberName = _MemberName;
        }
        public void QueryMember()
        {
            Console.WriteLine("你註冊的名字為{0}，今年{1}歲",MemberName,MemberAge);
        }

        public void Login()
        {
            Console.WriteLine("登入成功!!!");
            isLogin = true;
        }
        public void Shopping()
        {
            if (isLogin == true)
            {
                Console.WriteLine("購物結帳!!!");
            }
            else 
            {
                Console.WriteLine("請登入");
            }
        }
    }
}
