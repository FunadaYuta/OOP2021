using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Timers;
using System.Windows.Threading;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            dt = DateTime.Now;
        }
        DateTime dt;
        int count = 0;
        int answer = 0;

        private DispatcherTimer _timer;

        private void InitializeTimer() {
            // 優先順位を指定してタイマのインスタンスを生成
            _timer = new DispatcherTimer(DispatcherPriority.Background);

            // インターバルを設定
            _timer.Interval = new TimeSpan(0, 0, 1);

            // タイマメソッドを設定
            _timer.Tick += (e, s) => { TimerMethod(); };

            // 画面が閉じられるときに、タイマを停止
            this.Closing += (e, s) => { _timer.Stop(); };

            _timer.Start();
        }

        private void TimerMethod() {
            uxClock.Text = (DateTime.Now - dt).ToString("hh:mm:ss");

        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            Notification.Text = "";
            if (count == 0) {
                Random rm = new Random();
                answer = rm.Next(1, 26);
                InitializeTimer();
            }
            count++;

            var button = (Button)sender;
            int s = int.Parse(button.Content.ToString());
            if (s == answer) {
                Notification.Text = "せいかいです" + count + "回目" + answer + "が正解です";
            } else if (s > answer) {
                Notification.Text = "もっと小さい数字です" + count + "回目";
            } else {
                Notification.Text = "もっと大きい数字です" + count + "回目";
            }
            

        }

       

    }
}
