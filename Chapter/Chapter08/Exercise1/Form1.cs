using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BTAction_Click(object sender, EventArgs e) {
            //var today = new DateTime((int)NudYear.Value,(int)NudMonth.Value,(int)NudDay.Value);
            var datetime = dateTimePicker1.Value;
            DayOfWeek dayOfWeek = datetime.DayOfWeek;
            
            TBOutput.Text = GetWeek(dayOfWeek) + "です";

            //TBBrithday
            var isLeapYear = DateTime.IsLeapYear(datetime.Year);
            if (isLeapYear) TBLeapYear.Text = "閏年です";
            else TBLeapYear.Text = "閏年ではありません";


            var date2 = DateTime.Today;
            TimeSpan diff = date2 - datetime;
            TBOutput.Text = diff.Days + "日間";

            //TBage
            TBage.Text = GetAge(datetime, date2).ToString();
        }
        
        public static string GetWeek(DayOfWeek dayOfWeek) {
            string dow = "";
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
                default:
                    break;
            }
            return dow;
        }

        public static int GetAge(DateTime birthday,DateTime targetrDay) {
            var age = targetrDay.Year - birthday.Year;
            if(targetrDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

    }
}