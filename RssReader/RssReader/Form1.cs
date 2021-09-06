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

        List<string> urltitle = new List<string>();

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        public Form1() {
            InitializeComponent();
            
        }

        private void btRead_Click(object sender, EventArgs e) {
            setRssTitle(tbUrl.Text);


        }

        private void setRssTitle(string url) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var urll = new Uri(url);
                var stream = wc.OpenRead(urll);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                var links = xdoc.Root.Descendants("link");
                lbTitles.Items.Clear();
                foreach (var node in nodes) {
                    lbTitles.Items.Add(Regex.Replace(node.Value, "【|】", ""));
                }
                foreach(var link in links) {
                    urltitle.Add(link.Value);
                }
                
            }
        }

        private void lbTitles_Click(object sender, EventArgs e) {
            wbBrowser.Url = new Uri(urltitle[lbTitles.SelectedIndex]);
        }
    }
}
