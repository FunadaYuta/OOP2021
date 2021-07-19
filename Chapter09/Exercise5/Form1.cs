using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercise5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtFolder_Click(object sender, EventArgs e) {
            if (FBD.ShowDialog() == DialogResult.OK) {
                var di = new DirectoryInfo(FBD.SelectedPath);
                FileInfo[] files = di.GetFiles();
                foreach (var item in files) {
                    long size = item.Length;
                    if (size >= 1048576) {
                        TbFBD.Text += item.FullName + "\r\n";
                    }
                }

            }
        }
    }
}
