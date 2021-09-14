using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Section04_Json {
    class Program {
        static void Main(string[] args) {
            var keyword = "算用記";
            var content = GetFromWikipedia(keyword);
            Console.WriteLine(content ?? "見つかりませんでした");
        }

        private static object GetFromWikipedia(string keyword) {
            var wc = new WebClient();
            wc.QueryString = new NameValueCollection() {
                ["action"] = "query",
                ["prop"] = "revisions",
                ["rvprop"] = "content",
                ["format"] = "json",
                ["titles"] = HttpUtility.UrlEncode(keyword, Encoding.UTF8),
            };

            wc.Headers.Add("Content-type", "charset=UTF-8");
            var result = wc.DownloadString("http://ja.wikipedia.org/w/api.php");
            var xmldoc = XDocument.Parse(result);
            var rev = xmldoc.Root.Descendants("rev").FirstOrDefault();
            return HttpUtility.HtmlDecode(rev?.Value);
        }
    }

    public class Rootobject {
        public string batchcomplete { get; set; }
        public Warnings warnings { get; set; }
        public Query query { get; set; }
    }

    public class Warnings {
        public Main main { get; set; }
        public Revisions revisions { get; set; }
    }

    public class Main {
        public string _ { get; set; }
    }

    public class Revisions {
        public string _ { get; set; }
    }

    public class Query {
        public Normalized[] normalized { get; set; }
        public Pages pages { get; set; }
    }

    public class Pages {
        public _3030 _3030 { get; set; }
    }

    public class _3030 {
        public int pageid { get; set; }
        public int ns { get; set; }
        public string title { get; set; }
        public Revision[] revisions { get; set; }
    }

    public class Revision {
        public string contentformat { get; set; }
        public string contentmodel { get; set; }
        public string _ { get; set; }
    }

    public class Normalized {
        public string from { get; set; }
        public string to { get; set; }
    }

}
