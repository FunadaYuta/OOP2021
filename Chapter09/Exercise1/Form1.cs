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

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {

            //1
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"))) {
                    int count = 0;
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();//一行読み込み
                        if (line.Contains(keyword.Text)) {
                            ++count;
                        }
                    }
                    tbOutPut.Text += keyword.Text + "は" + count + "行に含まれていました" + "\r\n";
                }
            }


            


            
        }

        private void btOpen2_Click(object sender, EventArgs e) {
            //2
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadAllLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                int count = lines.Count(x => x.Contains(keyword.Text));
                tbOutPut.Text += keyword.Text + "は" + count + "行に含まれていました" + "\r\n";

            }
        }

        private void btOpen3_Click(object sender, EventArgs e) {
            //3
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                int counts = lines.Count(x => x.Contains(keyword.Text));
                tbOutPut.Text += keyword.Text + "は" + counts + "行に含まれていました" + "\r\n";

            }

        }
    }
}
