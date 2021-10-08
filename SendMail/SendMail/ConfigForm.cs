using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization;
using System.IO;
using System.Windows.Documents;

namespace SendMail {
    public partial class ConfigForm : Form {
        public ConfigForm() {
            InitializeComponent();

        }

        private List<string> tbList = new List<string>();   //TextBoxの文字列を格納するList


        Settings setting = Settings.GetInstance();


        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        //OKボタンを押す
        private void btOk_Click(object sender, EventArgs e) {
            if (Apply()) {  //trueが返って来た場合、画面を閉じる
                this.Close();
            }
        }

        //適用ボタンを押す
        private void btApply_Click(object sender, EventArgs e) {
            Apply();
        }

        //TextBoxの内容を確認し、instanceにセットする
        public bool Apply() {
            try {

                tbList.Add(tbHost.Text);
                tbList.Add(tbPass.Text);
                tbList.Add(tbPort.Text);
                tbList.Add(tbUserName.Text);
                tbList.Add(tbSender.Text);
                foreach(var item in tbList) {
                    // TextBoxの中身が　null、もしくは空文字列、もしくは空白文字列である
                    if ((item == null) || (item.Trim().Length == 0)) {  
                        MessageBox.Show("すべてに入力をしてください");
                        tbList.Clear();
                        return false;
                    }
                }

                //settingでinstanceにTextBoxの内容を格納する
                setting.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);
               
            }
            catch (Exception) {
                MessageBox.Show("正しく入力をしてください");
                return false;
            }
            
            //異常がない場合Trueを返す
            return true;
        }

        //キャンセルボタンを押す
        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        //デフォルトボタンを押す
        private void btDefault_Click(object sender, EventArgs e) {
           
            tbHost.Text = setting.sHost();
            tbUserName.Text = setting.sMailAddr();
            tbPort.Text = setting.sPort();
            tbPass.Text = setting.sPass();
            cbSsl.Checked = setting.sSsl();
            tbSender.Text = setting.sMailAddr();

        }

        private void ConfigForm_Load(object sender, EventArgs e) {

            //Xmlファイルをデシリアライズして、設定画面を開いた場合、TextBoxに表示する
            if ((setting.Host != null) && (setting.Host.Trim().Length != 0)) {
                tbHost.Text = setting.Host;
                tbUserName.Text = setting.MailAddr;
                tbPort.Text = setting.Port.ToString();
                tbPass.Text = setting.Pass;
                cbSsl.Checked = setting.Ssl;
                tbSender.Text = setting.MailAddr;
            }

        }
    }
}
