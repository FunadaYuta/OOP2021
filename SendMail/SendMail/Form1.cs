using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            string filepass = @"./settings.xml";
            if (!configForm.Visible && !File.Exists(filepass)) {
                configForm = new ConfigForm();
                configForm.ShowDialog();
            }
        }

        Settings setting = Settings.GetInstance();
        private ConfigForm configForm = new ConfigForm();

        private void btSend_Click(object sender, EventArgs e) {
            if(setting.Host == null || setting.Host == "") {
                MessageBox.Show("未設定です");
                if (!configForm.Visible) {
                    configForm = new ConfigForm();
                    configForm.Show();
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
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            if(e.Error != null) {
                MessageBox.Show(e.Error.Message);
            } else {
                MessageBox.Show("送信完了");
                tbTo.Text = "";
                tbCc.Text = "";
                tbBcc.Text = "";
                tbTitle.Text = "";
                tbMessage.Text = "";
            }
            
        }

        private void bcConfig_Click(object sender, EventArgs e) {
            if (!configForm.Visible) {
                configForm = new ConfigForm();
                configForm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
