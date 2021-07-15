using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Button5_2_Click(object sender, EventArgs e) {
            if(int.TryParse(inStrNum.Text, out int num)) {
                outStrNum.Text =num.ToString("#,0");
            } else {
                outStrNum.Text = "整数値を入力してください";
            }
        }

        private void Button5_3_Click(object sender, EventArgs e) {
            int count = 0;
            for (int i = 0; i < inStrNum.Text.Length; i++) {
                if (inStrNum.Text.Substring(i, 1) == " ") {
                    count++;
                }
            }
            outStrNum.Text = count.ToString();
        }
    }
}
