using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class ConfigForm : Form {
        public ConfigForm() {
            InitializeComponent();
        }

        public Settings setting = Settings.getInstance();

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void btOk_Click(object sender, EventArgs e) {
            Apply();
            this.Close();
            
        }

        private void btApply_Click(object sender, EventArgs e) {
            Apply();
        }

        private Settings Setreturn() {
            return setting;
        }

        public void Apply() {
            setting.Host = tbHost.Text;
            setting.Pass = tbPass.Text;
            setting.Port = int.Parse(tbPort.Text);
            setting.MailAddr = tbUserName.Text;
            setting.Ssl = cbSsl.Checked;
             
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btDefault_Click(object sender, EventArgs e) {
           
            tbHost.Text = setting.sHost();
            tbUserName.Text = setting.sMailAddr();
            tbPort.Text = setting.sPort();
            tbPass.Text = setting.sPass();
            cbSsl.Checked = setting.sSsl();
            tbSender.Text = setting.sMailAddr();

        }



    }
}
