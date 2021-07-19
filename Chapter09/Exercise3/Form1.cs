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

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        

        private void BtFileText_Click(object sender, EventArgs e) {
            var firstFilePath = TbFirstFileName.Text;
            var lastFIlePath = TbLastFileName.Text;
            if(File.Exists(firstFilePath) && File.Exists(lastFIlePath)) {

                var lines = File.ReadLines(lastFIlePath, Encoding.GetEncoding("shift_jis"));

                using (var writer = new StreamWriter(firstFilePath, append: true)) {
                    foreach(var item in lines) {
                        writer.WriteLine(item);
                    }
                }
            } else {
                MessageBox.Show("ファイル名が正しくありません","エラー");
            }
        }
    }
}
