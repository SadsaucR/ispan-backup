using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student :IStudy,IEat
    {
        public string StudentName { get; set; }
        public string Studyfunc (string description)
        {
            return $"{StudentName}的讀書方法為{description}(S)";
        }
        public string resteraunt(string rsname)
        {
            return $"{StudentName}在{rsname}吃飯(S)";
        }

    }
    class Teacher:IStudy,IEat
    {
        public string TeacherName { get; set; }

        public string Studyfunc(string description)
        {
            return $"{TeacherName}的讀書方法為{description}(T)";
        }
        public string resteraunt(string rsname)
        {
            return $"{TeacherName}在{rsname}吃飯(T)";
        }
    }
    // interface 介面 使用時機:有一大堆需要跨類別使用的方法
    interface IStudy
    {
        string Studyfunc(string description);
    }

    interface IEat
    {
        string resteraunt(string rsname);
    }
}
