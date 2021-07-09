using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {

        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            textBox1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        //スタートボタン
        private void tbstart_Click(object sender, EventArgs e) {
            tm.Tick += Tm_Tick;
            tm.Start();
            sw.Start();
        }

        private void Tm_Tick(object sender, EventArgs e) {
            textBox1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        //ストップボタン
        private void Tbstop_Click(object sender, EventArgs e) {
            tm.Stop();
            sw.Stop();
        }

        //リセットボタン
        private void TbReset_Click(object sender, EventArgs e) {
            sw.Reset();
            textBox1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            listBox1.Items.Clear();
            
        }

        //ラップ
        private void Btlap_Click(object sender, EventArgs e) {
            listBox1.Items.Insert(0,textBox1.Text);
        }
    }
}
