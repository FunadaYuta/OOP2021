using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }
        Setting setting = new Setting();
        private void btSend_Click(object sender, EventArgs e) {
            try {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress("ojsinfosys01@gmail.com");
                //宛先（To）
                mailMessage.To.Add(tbTo.Text); 
                mailMessage.CC.Add(tbCc.Text);
                mailMessage.Bcc.Add(tbBcc.Text);
                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報（ユーザー名、パスワード）
                new Setting();
                smtpClient.Credentials 
                    = new NetworkCredential(Setting.MailAddr,setting.Pass);
                smtpClient.Host = setting.Host;
                smtpClient.Port = setting.Port;
                smtpClient.EnableSsl = setting.Ssl;
                smtpClient.Send(mailMessage);

                MessageBox.Show("送信完了");

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void bcConfig_Click(object sender, EventArgs e) {
            new ConfigForm().ShowDialog();
        }
    }
}
