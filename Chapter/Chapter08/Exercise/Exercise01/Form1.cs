using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayofweek = culture.DateTimeFormat.GetDayName(today.DayOfWeek);
            tbDateDisp.Text = string.Format("{0:yyyy/M/d HH:mm}", today);
            tbDateDisp.Text += "\r\n" + today.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            tbDateDisp.Text += "\r\n" + today.ToString("ggyy年 M月d日(dddd)", culture);
            //tbDateDisp.Text += "\r\n" + string.Format(today.ToString("ggyy年 M月d日", culture) + "({0})",dayofweek);
        }

       
        private void Form1_Load(object sender, EventArgs e) {
            tm.Tick += Timer_Tick;
            tm.Interval = 1000;
            tm.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            tssTimeLabel.Text = now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
        }
    }
}
