using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Student:IComparable<Student>
    {
        public string name;
        public int tall;

       public Student(string name ,int tall)
        {
            this.name = name;
            this.tall = tall;

        }
        //比较方法
        public int CompareTo(Student other)
        {
            if (this.tall > other.tall)
                return 1;
            if (this.tall < other.tall)
                return -1;

            return 0;
        }

        public override string ToString()
        {
            return "{"+ name+":"+tall+"}";
        }
    }
}
