using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04 {
    class Program {
        static void Main(string[] args) {
            new Program();
        }

        //コンストラクタ
        public Program() {
                
            Console.WriteLine("地域コード入力");
            Console.WriteLine("1:前橋\n2:みなかみ\n3:宇都宮\n4:水戸\n9:その他（直接入力)");
            Console.Write(">");
            int num = int.Parse(Console.ReadLine());

            switch (num) {
                case 1:
                    num = 4210;
                    break;
                case 2:
                    num = 4220;
                    break;
                case 3:
                    num = 4110;
                    break;
                case 4:
                    num = 4010;
                    break;
                case 9:
                    Console.WriteLine("コードを入力して下さい");
                    Console.Write(">");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine("正しく入力して下さい");
                    new Program();
                    break;
                default:
                    Console.WriteLine("正しく入力して下さい");
                    new Program();
                    break;
            }


            var results = GetWeatherReportFromYahoo(num);
            foreach (var s in results) {
                Console.WriteLine(s);

            }

        }

        //リスト14.15
        public void DownloadString() {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://www.yahoo.co.jp/");
            Console.WriteLine(html);
        }

        //リスト14.17
        private void DownloadFileAsync() {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\yf32141\Downloads\8.zip");
            var filename = @"C:\temp\example.zip";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine();//アプリケーションが終了しないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e) {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e) {
            Console.WriteLine("ダウンロード完了");
        }

        //リスト14.18
        public void OpenReadSample() {
            var wc = new WebClient();
            using (var stream = wc.OpenRead("https://yahoo.co.jp/"))
            using (var sr = new StreamReader(stream, Encoding.UTF8)) {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);
            }

        }

        //リスト14.19
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }

    }
}
