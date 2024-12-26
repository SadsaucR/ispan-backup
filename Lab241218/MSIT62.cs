using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241218
{
    internal class MSIT62
    {
        public int StudentID;
        public string StudentName;
        public int Chinese;
        private static int IDtemp;
        public MSIT62()
        {

        }
        public MSIT62(string temp,int score)
        {
            Console.WriteLine("CALL {0}的建構子",temp);
            StudentName = temp;
            Chinese = score;
            IDtemp++;
            StudentID = IDtemp;
        }

        public void SayHi()
        {
            Console.WriteLine("{0}說早安我的學號是{1}我的國文考{2}分",StudentName,StudentID,Chinese);
        }
    }
}
