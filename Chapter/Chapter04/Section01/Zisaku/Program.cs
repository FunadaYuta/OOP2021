using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zisaku {
    class Program {
        static void Main(string[] args) {
            var filePath = @"C:\Users\infosys\Desktop\32141\unko.txt";
            using (var writer = new StreamWriter(filePath)) {
                Console.Write("文字路入れろ:");
                writer.WriteLine(Console.ReadLine());
                //if (File.Exists(filePath)) {
                //    var lines = File.ReadLines(filePath).Select((s, ix) => string.Format("{0,4}: {1}", ix + 1, s)).Where(x => x.Contains("a"));
                //    foreach (var line in lines) {
                //        Console.WriteLine(line);
                //    }

                //}
            }
        }
    }
}
