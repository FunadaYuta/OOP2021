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

        IEnumerable<ItemDate> items = null;

        List<string> urllink = new List<string>();//url
        List<string> descriptionlist = new List<string>();//descripition
        List<string> pubDatelist = new List<string>();//pubDate

        List<string> str = new List<string>();
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

        //URLを読み取り、タイトルをSet
        private void setRssTitle(string url) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                
                
                try {
                    var urll = new Uri(url);
                    var stream = wc.OpenRead(urll);
                    XDocument xdoc = XDocument.Load(stream);

                    lbTitles.Items.Clear();

                    items = xdoc.Root.Descendants("item").Select(x => new ItemDate{
                        Title = (string)x.Element("title"),
                        Link = (string)x.Element("link"),
                        PubDate = (DateTime)x.Element("pubDate"),
                        Description = (string)x.Element("description")
                    });

                    foreach (var item in items) {
                        lbTitles.Items.Add(item.Title);
                    }


                    
                }
                catch(Exception e) {
                    MessageBox.Show("URLが正しく入力されていません。");
                }

                
                

            }
        }

        //lbtitlesのタイトルを選択
        private void lbTitles_Click(object sender, EventArgs e) {
            int index = lbTitles.SelectedIndex;
            string link = (items.ToArray())[lbTitles.SelectedIndex].Link;//配列へ変換して[]でアクセス
            DateTime dt = (items.ToArray())[lbTitles.SelectedIndex].PubDate;
            string desc = (items.ToArray())[lbTitles.SelectedIndex].Description;
            Screen(link, dt, desc);
        }

        //Form1に選択されたタイトルの説明とURLと日付を表示させる
        public void Screen(string link,DateTime dt,string desc) {
            lbpubdata.Text = dt.ToString("yyyy年MM月dd日 hh時mm分ss秒 投稿");
            lburl.Text = link;
            lbdescription.Text = desc;
        }

        //次へボタンを押した場合
        private void btNextTitle_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(tbUrl.Text) && lbTitles.Items.Count > 0) {
                int index = lbTitles.SelectedIndex;
                if (index == lbTitles.Items.Count - 1) {
                    lbTitles.SelectedIndex = 0;
                } else {
                    lbTitles.SelectedIndex++;
                }
                //配列へ変換して[]でアクセス
                string link = (items.ToArray())[lbTitles.SelectedIndex].Link;
                DateTime dt = (items.ToArray())[lbTitles.SelectedIndex].PubDate;
                string desc = (items.ToArray())[lbTitles.SelectedIndex].Description;
                Screen(link, dt, desc);
            }
        }

        //Webサイトを表示ボタンが押された場合
        private void WebSiteOpen_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            if (!string.IsNullOrEmpty(lburl.Text)) {
                form2.ScreenShow(lburl.Text);
                form2.Show();

            }
            
            
            
        }

       
    }
}