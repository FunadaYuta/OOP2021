using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {

    public partial class Form1 : Form {

        List<string> urllink = new List<string>();//url
        List<string> descriptionlist = new List<string>();//descripition
        List<string> pubDatelist = new List<string>();//pubDate

        private void Form1_Load(object sender, EventArgs e) {

        }

        public Form1() {
            InitializeComponent();

        }

        //表示ボタン
        private void btRead_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(tbUrl.Text)) {
                setRssTitle(tbUrl.Text);
            }
        }

        private void setRssTitle(string url) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var urll = new Uri(url);
                var stream = wc.OpenRead(urll);

                XDocument xdoc = XDocument.Load(stream);
                var item = xdoc.Root.Descendants("item");
                var nodes = xdoc.Root.Descendants("title");
                var links = xdoc.Root.Descendants("link");
                var descriptions = xdoc.Root.Descendants("description");
                var pubDates = xdoc.Root.Descendants("pubDate");
                lbTitles.Items.Clear();
                foreach (var i in item) {
                    lbTitles.Items.Add(Regex.Replace(i.Element("title").Value, "【|】", ""));
                    urllink.Add(i.Element("link").Value);
                    descriptionlist.Add(i.Element("description").Value);
                    pubDatelist.Add(i.Element("pubDate").Value);
                    //foreach (var node in nodes)
                    //    lbTitles.Items.Add(Regex.Replace(node.Value, "【|】", ""));
                    //foreach (var link in links)
                    //    urllink.Add(link.Value);
                    //foreach (var description in descriptions)
                    //    descriptionlist.Add(description.Value);
                    //foreach (var pubDate in pubDates)
                    //    pubDatelist.Add(pubDate.Value);
                }
                

            }
        }

        //タイトルを選択
        private void lbTitles_Click(object sender, EventArgs e) {
            int index = lbTitles.SelectedIndex;
            Screen(index);
        }

        //画面を表示させる
        public void Screen(int index) {

            tbDescription.Text = "";
            tbpubDate.Text = "";
            tburltitle.Text = "";

            DateTime dt;
            if (DateTime.TryParse(pubDatelist[index], out dt) == true) {
                tbpubDate.Text += dt.ToString("yyyy年MM月dd日 hh時mm分ss秒 投稿");
            }

            tburltitle.Text = urllink[index];
            tbDescription.Text = descriptionlist[index];
        }

        //次へボタンが押された場合
        private void btNextTitle_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(tbUrl.Text) && lbTitles.Items.Count > 0) {
                int index = lbTitles.SelectedIndex;
                if (index == lbTitles.Items.Count - 1) {
                    lbTitles.SelectedIndex = 0;
                    Screen(0);

                } else {
                    index = lbTitles.SelectedIndex++;
                    Screen((index + 1));
                }

            }
        }

        private void WebSiteOpen_Click(object sender, EventArgs e) {

        }
    }
}