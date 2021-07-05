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
        }

        private void Tm_Tick(object sender, EventArgs e) {
            
            sw.Start();
            TimeSpan ts = sw.Elapsed;
            textBox1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        //ストップボタン
        private void tbstop_Click(object sender, EventArgs e) {
            tm.Stop();
        }

        //リセットボタン
        private void tbReset_Click(object sender, EventArgs e) {
            sw.Reset();
            textBox1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            tm.Stop();
        }

        //ラップ
        private void btlap_Click(object sender, EventArgs e) {
            textBox2.Text = textBox1.Text + "\r\n" + textBox2.Text ;
        }
    }
}
