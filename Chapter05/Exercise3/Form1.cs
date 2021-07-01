using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }

        private void Button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(c => c == ' ');
            outputStrText1.Text = count.ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            if (big.Text.Length > 0 && small.Text.Length > 0) {
                outputStrText2.Text = inputStrText.Text.Replace(big.Text, small.Text);
            }
        }

        //フォームがロードされるタイミングで１回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            inputStrText2.Text = "NoveList=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void Button5_3_3_Click(object sender, EventArgs e) {
            outputStrText3.Text = inputStrText.Text.Split(' ').Count().ToString();

        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            var word = inputStrText.Text.Split(' ').Where(c => c.Length <= 4);
            foreach (var item in word) {
                outputStrText4.Text += item + " ";
            }
        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            var array = inputStrText.Text.Split(' ').ToArray();
            if(array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach(var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                outputStrText5.Text = sb.ToString();
            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            outputStrText1.Text = "";
            outputStrText2.Text = "";
            outputStrText3.Text = "";
            outputStrText4.Text = "";
            outputStrText5.Text = "";
            output5_4.Text = "";
        }

        private void Button5_4_Click(object sender, EventArgs e) {
            //string novelist = "",bestwork = "",born = ""; 
            foreach (var item in inputStrText2.Text.Split(';')) {
                var array = item.Split('=');
                output5_4.Text += ToJapanese(array[0]) + ":" + array[1] + "\r\n";
                //if (item.Contains("NoveList")) novelist = item.Substring(item.IndexOf("=")+1);
                //if (item.Contains("BestWork")) bestwork = item.Substring(item.IndexOf("=")+1);
                //if (item.Contains("Born")) born = item.Substring(item.IndexOf("=")+1);
            }
            //output5_4.Text = string.Format("作家　 : {0} \r\n代表作: {1}\r\n誕生日: {2}",novelist, bestwork, born);
        }
        private string ToJapanese(string key) {
            switch (key) {
                case "NoveList":
                    return "作家";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生日";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}
