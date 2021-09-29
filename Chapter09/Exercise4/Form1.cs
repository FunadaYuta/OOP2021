using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtFilePath_Click(object sender, EventArgs e) {
            if (OFD.ShowDialog() == DialogResult.OK) {
                int a = OFD.FileName.IndexOf(".")-1;//識別子より前のものを選択
                int c = OFD.FileName.LastIndexOf("\\");//最後の\マークの所を選択
                string str = OFD.FileName.Substring(c,a-c);
                string str2 = OFD.FileName.Substring(a + 1);
                File.Copy(OFD.FileName, TbDirectory.Text + str + "_bak" + str2,overwrite:true);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

          }
}
