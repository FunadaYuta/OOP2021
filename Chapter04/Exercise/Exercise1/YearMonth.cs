using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    public class YearMonth {

        public int Year { get;  }
        public int Month { get; }

        public bool Is21Century {
            get {
                return 2001 <= this.Year && this.Year <= 2100 ;
            }
        }

        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }

        public YearMonth AddOneMonth() {
            int month = this.Month+1;
            int year = this.Year;
            if (month == 13) {
                year++;
                month = 1;
            }
            YearMonth yearMonth = new YearMonth(year,month);
            return yearMonth;
        }

        public override string ToString() {
            return this.Year + "年" + this.Month + "月";
        }


    }
}
