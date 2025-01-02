using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241227
{
    internal class Phone
    {
        public string PhoneName { get; }
        public string PhoneColor { get; }
        public int PhoneStorage { get; }

        //建構子
        public Phone(string PN, string PC, int PS)
        {
            
            Console.WriteLine("建構手機{0}!", PhoneName);
            PhoneName = PN;
            this.PhoneColor = PC; //使用this可以指定父Class
            PhoneStorage = PS;
            Console.WriteLine("已加入手機 {0} {1} {2}GB!", PhoneName,PhoneColor,PhoneStorage);

        }
        public Phone() //繼承用
        {
            Console.WriteLine("建構手機{0}!", PhoneName);
            PhoneName = "Iphone 14 pro";
            this.PhoneColor = "金剛黑";
            PhoneStorage = 256;
            Console.WriteLine("已加入手機 {0} {1} {2}GB!", PhoneName, PhoneColor, PhoneStorage);
        }

        public void OKGoogle()
        {
            Console.WriteLine("{0}的Google助理說:嗨!",PhoneName);
        }
        public void Capture()
        {
            Console.WriteLine("{0}:喀擦!",PhoneName);
        }
        public void Call()
        {
            Console.WriteLine("{0}:您撥的號碼是空號...請查明後再撥...",PhoneName);
        }
    }
    //繼承用法 新cls : 舊cls
    class iPhone : Phone { }
    class amaPhone : Phone
    {
        //如果使用此空建構式，會先呼叫父建構式，才會呼叫子建構式，會呼叫兩次。
        public amaPhone()
        {
            Console.WriteLine("已加入阿罵的手機 {0} {1} {2}GB!", PhoneName, PhoneColor, PhoneStorage);
        }
        public amaPhone(string city, string store)
        {
            Console.WriteLine("已加入阿罵在{0}{1}買的手機 {2} {3} {4}GB!", city, store, PhoneName, PhoneColor, PhoneStorage);
        }
        //修正後:加入base，將子建構值傳入父建構值。
        public amaPhone(string city, string store,string name,string color,int storage) : base(name,color,storage)
        {
            Console.WriteLine("已加入阿罵在{0}{1}買的手機\n {2} {3} {4}GB!", city, store, PhoneName, PhoneColor, PhoneStorage);
        }
        //new,override 子類別呼叫同名函數會用到
        public new void OKGoogle()
        {
            base.OKGoogle(); //呼叫父類別的函數
            Console.WriteLine("叮咚");
        }


    }
    
}
