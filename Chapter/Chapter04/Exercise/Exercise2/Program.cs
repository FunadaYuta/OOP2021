using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            //4.2.1
            var YearMonths = new YearMonth[5]{
                new YearMonth(9999,12),
                new YearMonth(2100,4),
                new YearMonth(1400,7),
                new YearMonth(203110,9),
                new YearMonth(2001,12),
            };

            //4.2.2
            Exercise2_2(YearMonths);

            Console.WriteLine("-----------------------");

            //4.2.4
            Exercise2_4(YearMonths);


            Console.WriteLine("-----------------------");

            //4.2.5
            Exercise2_5(YearMonths);
            
        }

        

        private static void Exercise2_2(YearMonth[] yearMonths) {
            foreach (var item in yearMonths) {
                Console.WriteLine(item);
            }
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var item in yms) {
                if (item.Is21Century) {
                    return item;
                }
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] yearMonths) {
            var Is21Data = yearMonths.Contains(FindFirst21C(yearMonths))
                ? FindFirst21C(yearMonths).Year.ToString() + "年" : "21世紀のデータはありません";
            Console.WriteLine(Is21Data);
        }

        private static void Exercise2_5(YearMonth[] yearMonths) {
            var OneMonthLater = yearMonths.Select(y => y.AddOneMonth()).OrderBy(x => x.Year).ToArray();
            foreach (var item in OneMonthLater) Console.WriteLine(item);
        }
    }
}