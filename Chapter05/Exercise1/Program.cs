using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            #region 問題5_1
            //Console.Write("文字列1 :");
            //var str1 = Console.ReadLine();
            //Console.Write("文字列1 :");
            //var str2 = Console.ReadLine();

            //if (String.Compare(str1,str2,ignoreCase:true) == 0) {
            //    Console.WriteLine("文字列１と２は等しいです");
            //} else {
            //    Console.WriteLine("文字列１と２は等しくありません");
            //}
            #endregion

            #region 5_2
            string instr = Console.ReadLine();
            int.TryParse(instr, out int intstr);
            Console.WriteLine("{0:#,0}",intstr);


            #endregion
        }
    }
}
