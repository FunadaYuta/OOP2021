using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {

        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;

        }

        private void Form1_Load(object sender, EventArgs e) {


        }


        //終了ボタン
        private void BtExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーション終了
        }

        //画像を開くボタン
        private void BtPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);//画像を移す
            }

        }

        //画像を削除するボタン
        private void PbPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //追加ボタン
        private void BtEDataAdd_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("すべての項目を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }



            CarReport carReport = new CarReport() {
                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = SelectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            listCarReport.Add(carReport); //1レコード追加

            //コンボボックスの履歴登録
            SetCbAuther(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);
        }

        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup SelectedGroup() {
            foreach (var rb in GbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse((string)((RadioButton)rb).Tag);
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void SetCbAuther(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }

        }

        //コンボボックスに車名をセットする
        private void SetCbCarName(string author) {
            if (!cbCarName.Items.Contains(author)) {
                cbCarName.Items.Add(author);
            }

        }


        //作成されたリストを表示する
        private void DgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) return;

            CarReport selectedCar = listCarReport[e.RowIndex];
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;


            SetMakerRadioButton(selectedCar.Maker);
        }

        //作成されたリストのメーカーをチェックする
        private void SetMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        //リストを削除する
        private void BtDataDelete_Click(object sender, EventArgs e) {
            if (listCarReport.Count == 0) return;
            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);//選択されている行を取り出して削除
        }

        //リストを修正する
        private void BtDataCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistData.CurrentRow.Index].UpDate(
                dtpDate.Value,cbCarName.Text,
                SelectedGroup(),cbAuthor.Text,
                tbReport.Text,pbPicture.Image);
            dgvRegistData.Update();
        }
    }
}
