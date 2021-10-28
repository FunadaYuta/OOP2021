using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            //carReportDataGridView.DataSource = listCarReport;


        }

        private void fmMain_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202130DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。

            //carReportDataGridView.Columns[5].Visible = false;
        }

    private void btExit_Click(object sender, EventArgs e) {
            Application.Exit(); //アプリケーション終了
        }
        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {

            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            listCarReport.Add(carReport);   //１レコード追加

            //コンボボックスの履歴登録
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
        }

        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup() {

            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        //DataGlidViewの一つのデータをクリック
        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            //選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            //取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }

        private void setMakerRadioButton(CarReport.MakerGroup mg) {
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
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;
                default:    //その他
                    rbOther.Checked = true;
                    break;
            }
        }

        //データを削除ボタン
        private void btDataDelete_Click(object sender, EventArgs e) {
            //if (carReportDataGridView.CurrentCell != null) {
            //    listCarReport.RemoveAt(carReportDataGridView.CurrentRow.Index);
            //}
        }

        //データを編集ボタン
        private void btDataCorrect_Click(object sender, EventArgs e) {
            //listCarReport[carReportDataGridView.CurrentRow.Index].UpDate(dtpDate.Value,
            //                                                    cbAuthor.Text,
            //                                                    selectedGroup(),
            //                                                    cbCarName.Text,
            //                                                    tbReport.Text,
            //                                                    pbPicture.Image
            //                                                    );
            //carReportDataGridView.Refresh(); //コントロールの強制再描画
        }

        //更新ボタンイベント処理
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    //日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;    //記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();  //メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   //社名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    //レポート

            //データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202130DataSet);
#if false
            if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    // バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString(), "エラー");
                }

            }
#endif 
        }

        //DBに接続するボタン
        private void btConnect_Click(object sender, EventArgs e) {
            this.carReportTableAdapter.Fill(this.infosys202130DataSet.CarReport);


#if fasle
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    // バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        // 逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
                    }
                }
                catch (System.Runtime.Serialization.SerializationException ex) {
                    MessageBox.Show(ex.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //読み込んだデータを各コンボボックスに登録する
                for (int i = 0; i < dgvRegistData.RowCount; i++) {
                    setCbAuthor(listCarReport[i].Auther);
                    setCbCarName(listCarReport[i].CarName);
                }
            }
#endif
        }


       

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202130DataSet);

        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            //if (carReportDataGridView.CurrentRow == null) return;
            //dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;
            //cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();
            //cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();
            //tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
