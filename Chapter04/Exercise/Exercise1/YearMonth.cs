using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    public class YearMonth {

        public int Year { get; }
        public int Month { get; }

        public bool Is21Century {
            get {
                return 2001 <= this.Year && this.Year <= 2100;
            }
        }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        public YearMonth AddOneMonth() {
            if (this.Month == 12) return new YearMonth(this.Year + 1, 1);
            return new YearMonth(this.Year, this.Month + 1);
        }

        public override string ToString() {
            return this.Year + "年" + this.Month + "月";
        }


    }
}