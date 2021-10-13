using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        Settings setting;

        ConfigForm configForm = new ConfigForm();

        private void btSend_Click(object sender, EventArgs e) {

            //settingに情報がない場合は設定画面を呼び出す
            if((setting.Host == null) || (setting.Host.Trim().Length == 0)) {
                MessageBox.Show("未設定です");
                if (!configForm.Visible) {  //設定画面が一つもない場合
                    configForm = new ConfigForm();
                    configForm.ShowDialog();
                }
                return;
            }

            try {
                //メール送信のためのインスタンスを生成

                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(setting.MailAddr);

                //宛先（To）

                mailMessage.To.Add(tbTo.Text);

                if (tbCc.Text != "")
                    mailMessage.CC.Add(tbCc.Text);
                if (tbBcc.Text != "")
                    mailMessage.Bcc.Add(tbBcc.Text);

                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                if ((tbMessage.Text == null) || (tbMessage.Text.Trim().Length == 0)) {
                    MessageBox.Show("本文を入力してください");
                    return;
                }
                    mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報（ユーザー名、パスワード）


                smtpClient.Credentials
                    = new NetworkCredential(setting.MailAddr, setting.Pass);
                smtpClient.Host = setting.Host;
                smtpClient.Port = setting.Port;
                smtpClient.EnableSsl = setting.Ssl;
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);
                btSend.Enabled = false;
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //非同期で送信し、送信の可否を表示する
        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            if(e.Error != null) {
                MessageBox.Show(e.Error.Message);
            } else {
                MessageBox.Show("送信完了");
                reset_tb();
            }
            btSend.Enabled = true;
        }

        private void reset_tb() {
            tbTo.Clear();
            tbCc.Clear();
            tbBcc.Clear();
            tbTitle.Clear();
            tbMessage.Clear();
        }

        //設定ボタンを押す
        private void bcConfig_Click(object sender, EventArgs e) {
            if (!configForm.Visible) {
                configForm = new ConfigForm();
                configForm.ShowDialog();
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e) {
            reset_tb();
        }

        private void Form1_Load(object sender, EventArgs e) {
            setting = Settings.GetInstance();
        }
    }
}
