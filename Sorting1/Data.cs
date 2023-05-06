using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1
{
    class Data :IComparable<Data>
    {
        private int year;
        private int mouth;
        private int day;
        private string heppen;

        public Data(int year,int mouth,int day,string heppen)
        {
            this.year = year;
            this.mouth = mouth;
            this.day = day;
            this.heppen = heppen;
        }

        public int CompareTo(Data other)
        {
            //按年/月/日排序
            if (this.year > other.year) return 1;
            if (this.year < other.year) return -1;
            if (this.mouth > other.mouth) return 1;
            if (this.mouth < other.mouth) return -1;
            if (this.day > other.day) return 1;
            if (this.day <other.day) return -1;

            return 0;
        }

        public override string ToString()
        {
            return year + "/" + mouth + "/" + day+"/"+heppen;
        }
    }
}
