using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var names = new List<String> {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong"
            };
            /*
            //3.1.1
            Exercise1_1(numbers);

            Console.WriteLine("---------------------");

            //3.1.2
            Exercise1_2(numbers);

            Console.WriteLine("---------------------");

            //3.1.3
            Exercise1_3(numbers);

            Console.WriteLine("---------------------");

            //3.1.4
            Exercise1_4(numbers);

            Console.WriteLine("---------------------");

            //3.2.1
            Exercise2_1(names);

            Console.WriteLine("---------------------");

            //3.2.2
            Exercise2_2(names);

            Console.WriteLine("---------------------");

            //3.2.3
            Exercise2_3(names);

            Console.WriteLine("---------------------");

           //3.2.4
            Exercise2_4(names);

            
            */

            Exericse3_1(names);

            Console.WriteLine("---------------------");

            Exercise3_2();

        }

        private static void Exercise3_2() {
            Console.WriteLine("文字列を10個入力");
            List<string> strings = new List<string>();
            for(int i = 0; i < 10; i++) {
                string s = Console.ReadLine();
                strings.Add(s);
                
            }

            Console.WriteLine("1. 小文字のカウント");
            Console.WriteLine("2. 大文字のカウント");
            Console.WriteLine("3. 数字のカウント");

            Console.WriteLine("処理を選択");
            string num = Console.ReadLine();
            int count = 0;

            if(num == "1") {
                Console.WriteLine(">1");
                foreach (var item in strings)
                    count += item.Count(c => char.IsLower(c));
                Console.WriteLine("小文字は" + count +"です");

            } else if(num == "2") {
                Console.WriteLine(">2");
                foreach (var item in strings)
                    count += item.Count(c => char.IsUpper(c));
                Console.WriteLine("大文字は" + count + "です");

            } else if (num == "3") {
                Console.WriteLine(">3");
                foreach (var item in strings)
                    count += item.Count(c => char.IsDigit(c) );
                Console.WriteLine("数字は" + count + "です");

            } else {
                Console.WriteLine("1,2,3のいずれかを入力してください");
            }

        }

        private static void Exericse3_1(List<string> names) {
            int count = 0;
            foreach(var item in names) {
                count += item.Count(c => char.IsLower(c));
            }
            Console.WriteLine(count);

            //int sum = 0;
            //var query = names.Select(s => s.ToLower()).ToList();
            //var names2 = names.Select(s => s).ToList();
            //for (int i = 0; i < query.Count; i++) {
            //    for (int j = 0; j < query[i].Length; j++) {
            //        if (query[i][j] == names2[i][j] && query[i][j] != ' ') {
            //            sum++;
            //        }
            //    }
            //}

            //Console.WriteLine(sum);
        }

        private static void Exercise2_4(List<string> names) {
            var query = names.Where(s => s[0] == 'B').Select(s => s.Length);
            foreach (var item in query) Console.WriteLine(item);
        }

        private static void Exercise2_3(List<string> names) {
            List<string> city = names.Where(s => s.Contains("o")).ToList();
            foreach (var item in city) Console.WriteLine(item);
        }

        private static void Exercise2_2(List<string> names) {
            var query = names.Count(s => s.Contains("o"));
            Console.WriteLine(query);
        }

        private static void Exercise2_1(List<string> names) {
            Console.Write("都市名を入力してください: ");
            var line = Console.ReadLine();
            var index = names.FindIndex(s => s == line);
            Console.WriteLine(index);
        }

        private static void Exercise1_4(List<int> numbers) {

            List<int> list = numbers.Select(s => s * 2).ToList();
            foreach (var item in list) Console.WriteLine(item);
        }

        private static void Exercise1_3(List<int> numbers) {
            foreach (var item in numbers.Where(s => s >= 50))
                Console.WriteLine(item);
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(s => Console.WriteLine(s / 2.0));
            
        }

        private static void Exercise1_1(List<int> numbers) {
            var query = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            if (query) Console.WriteLine("存在します");
            else Console.WriteLine("存在しません");
        }
    }

    

}
