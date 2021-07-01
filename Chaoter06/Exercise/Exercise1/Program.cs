using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };


            Exercise1_1(numbers);
            Console.WriteLine("-----------");
            Exercise1_2(numbers);
            Console.WriteLine("-----------");
            Exercise1_3(numbers);
            Console.WriteLine("-----------");
            Exercise1_4(numbers);
            Console.WriteLine("-----------");
            Exercise1_5(numbers);
            
            
            
            
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            foreach (var item in numbers.Reverse().Take(2)) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            foreach (var item in numbers) {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }

        private static void Exercise1_4(int[] numbers) {
            var mins = numbers.OrderBy(x => x).Take(3);
            foreach (var item in mins) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void Exercise1_5(int[] numbers) {
            Console.WriteLine( numbers.Distinct().Count(x => x > 10));
            
        }
    }
}
