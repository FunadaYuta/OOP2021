using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            

            var YearMonths = new YearMonth[5]{
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };

            foreach(var item in YearMonths) {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("-----------------------");

            Is21return(YearMonths);         
        }

        private static YearMonth Is21return(YearMonth[] yms) {
            int count = 0;
            foreach(var item in yms) {
                if (item.Is21Century) {
                    Console.WriteLine(item);
                    count++;
                }
            }
            if (count == 0) Console.WriteLine("null");
            return yms[1];
        }
    }
}
