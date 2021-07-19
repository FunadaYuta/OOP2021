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

namespace Exercise2 {
    public partial class Form1 : Form {
        string[] lines;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void BtFileOpen_Click(object sender, EventArgs e) {
            if (OFD.ShowDialog() == DialogResult.OK) {
                lines = File.ReadLines(OFD.FileName, Encoding.GetEncoding("shift_jis"))
                    .Select((s, ix) => string.Format("{0,4}:{1}", ix + 1, s)).ToArray();

                foreach (var item in lines) {
                    TbNewFile.Text += item + "\r\n";
                }


            }
        }

        private void BTSFD_Click(object sender, EventArgs e) {
            if (SFD.ShowDialog() == DialogResult.OK) {
                using (var writer = new StreamWriter(SFD.FileName)) {
                    foreach(var item in lines) {
                        writer.WriteLine(item);
                    }
                }
            }
        }
    }
}
