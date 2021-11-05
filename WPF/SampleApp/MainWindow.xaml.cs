using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show(string.Format("入力された文字は{0}文字です", MessageTextBox.Text.Trim().Length));
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("キャンセルされました");
        }
    }
}
