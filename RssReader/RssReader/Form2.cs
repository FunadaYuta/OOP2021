using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader {
    public partial class Form2 : Form {
        private void Form2_Load(object sender, EventArgs e) {
           
        }
        public Form2() {
            InitializeComponent();
            
        }

        public void ScreenShow(string s) {
            wbBrowser.Url = new Uri(s);
        }

      

        private void btReturn_Click(object sender, EventArgs e) {
            if (wbBrowser.CanGoBack) {
                wbBrowser.GoBack();
            }
        }

        private void btNext_Click(object sender, EventArgs e) {
            if (wbBrowser.CanGoForward) {
                wbBrowser.GoForward();
            } 
            
        }

        //Webブラウザを読み取った場合
        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            //ブラウザが戻れる場合
            btReturn.Enabled = wbBrowser.CanGoBack;
            btNext.Enabled = wbBrowser.CanGoForward;
        }
}
    }
}
