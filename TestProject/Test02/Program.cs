using System;
using System.Collections.Generic;
using System.Linq;

namespace Test02 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> {
                    12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48
                };
            #region テスト用ドライバ
            Console.WriteLine("問題１：合計値");
            Exercise01(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題２：偶数の最大値");
            Exercise02(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題３：昇順");
            Exercise03(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題４：10 以上 50 以下のみ");
            Exercise04(numbers);
            Console.WriteLine("\n-----");
            #endregion
        }

        //---------------------------------------
        // 以下の問題に書かれている内容を満たすようにプログラムを作成せよ。
        // 必要であればラムダ式とLINQを使用すること
        //　
        //---------------------------------------

        //問題１　合計値を表示
        //　　　　出力結果【618】
        private static void Exercise01(List<int> numbers) {



        }

        //問題２　偶数の最大値を表示
        //　　　　出力結果【94】
        private static void Exercise02(List<int> numbers) {



        }
        //問題３　昇順に並べて表示（遅延実行とする）
        //　　　　出力結果【12 14 17 20 31 35 40 48 53 76 87 91 94】
        private static void Exercise03(List<int> numbers) {



        }

        //問題４　10以上50以下の数字のみを表示（即時実行でも可とする）
        //　　　　出力結果【12 14 20 40 35 31 17 48】
        private static void Exercise04(List<int> numbers) {



        }
    }
}
