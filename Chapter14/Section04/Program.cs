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

        static Dictionary<string, int> AreaDic = new Dictionary<string, int>() {
            {"前橋",4210 },
            {"みなかみ",4220 },
            {"宇都宮",4110 },
            {"水戸", 4010}
        };

        List<int> numlist = new List<int>();//地域コードを順番に格納

        static void Main(string[] args) {
            new Program();
        }

        //コンストラクタ
        public Program() {
            
            int n = 0;

            Console.WriteLine("\n番号を選択");

            foreach(KeyValuePair<string,int> pair in AreaDic) {
                Console.WriteLine("{0}:{1}", n++, pair.Key);
                numlist.Add(pair.Value);
            }

            Console.WriteLine("99:その他（直接入力)");
            Console.Write(">");

            int num = int.Parse(Console.ReadLine());//番号を入力
            int cord;//地域コード

            if (num == 99) {//新しく入力する場合
                Console.WriteLine("\n地域名を入力して下さい");
                Console.Write(">");
                string area = Console.ReadLine();//地域名
                Console.WriteLine("コードを入力して下さい");
                Console.Write(">");
                cord = int.Parse(Console.ReadLine());//地域コード
                AreaDic.Add(area, cord);//ディクショナリーに追加
            } else {//既存の番号または誤入力
                cord = numlist[num];
            }
            
            var results = GetWeatherReportFromYahoo(cord);
            foreach (var s in results) {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n0:終わる\n1:続ける");
            Console.Write(">");
            int result = int.Parse(Console.ReadLine());
            if (result == 1) new Program();

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
