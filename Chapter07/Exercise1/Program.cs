using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            string str = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(str);
            Console.WriteLine("-----------");
            Exercise1_2(str);

            
        }

        private static void Exercise1_2(string str) {
            string s = str.ToUpper();
            var dict = new SortedDictionary<char, int>();

            foreach (var i in s) {
                if (dict.ContainsKey(i)) {
                    dict[i]++;
                } else if ('A' <= i && i <= 'Z') {
                    dict.Add(i, 1);
                }
            }

            foreach (var item in dict) {
                Console.WriteLine("'" + item.Key + "':" + item.Value);
            }
        }

        private static void Exercise1_1(string str) {
            string s = str.ToUpper();
            var dict = new Dictionary<char, int>();

            foreach (var i in s) {
                if (dict.ContainsKey(i)){
                    dict[i]++;
                } else if ('A' <= i && i <= 'Z') {
                    dict.Add(i, 1);
                }
            }
            ;
            foreach (var item in dict.OrderBy(x => x.Key)) {
                Console.WriteLine("'"+item.Key + "':" + item.Value);
            }
        }
    }
}
