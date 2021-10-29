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
        //BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            //carReportDataGridView.DataSource = listCarReport;


        }

        private void fmMain_Load(object sender, EventArgs e) {

            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[6].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車名";
            carReportDataGridView.Columns[5].HeaderText = "レポート";


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
        private void setMakerRadioButton(string str) {
            switch (str) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外国車":
                    rbImport.Checked = true;
                    break;
                default:    //その他
                    rbOther.Checked = true;
                    break;
            }
        }


        //更新ボタンイベント処理
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null)return;
            if(cbCarName.Text == "") {
                MessageBox.Show("社名を入力してください");
                return;
            }

            for (int i = 0; i < carReportDataGridView.RowCount; i++) {
                setCbAuthor(cbAuthor.Text);
                setCbCarName(cbCarName.Text);
            }


            bindingNavigatorAddNewItem.Enabled = true;
            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    //日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;    //記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();  //メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   //社名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    //レポート

            carReportDataGridView.CurrentRow.Cells[6].Value = pbPicture.Image;  //画像

            //データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202130DataSet);
        }

        //DBに接続するボタン
        private void btConnect_Click(object sender, EventArgs e) {
            this.carReportTableAdapter.Fill(this.infosys202130DataSet.CarReport);
            for (int i = 0; i < carReportDataGridView.RowCount; i++) {
                setCbAuthor((string)carReportDataGridView.Rows[i].Cells[2].Value.ToString());
                setCbCarName((string)carReportDataGridView.Rows[i].Cells[4].Value.ToString());
            }
        }


       

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202130DataSet);
            

        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            //追加して何も作成していない場合
            
            if (carReportDataGridView.CurrentRow == null)return;
            try {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();
                setMakerRadioButton(carReportDataGridView.CurrentRow.Cells[3].Value.ToString());
                //setMakerRadioButton
                //    ((CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup),
                //    carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));
                //メーカー（文字列→列挙型）
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();
                if (cbCarName.Text != "") {
                    bindingNavigatorAddNewItem.Enabled = true;
                }
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);
                
            }
            catch (Exception) {
                pbPicture.Image = null;
            }
        }

        // バイト配列をImageオブジェクトに変換
            public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            dtpDate.Value = DateTime.Today;
            cbAuthor.ResetText();
            rbOther.Checked = true;
            cbCarName.ResetText();
            tbReport.Clear();
            pbPicture.Image = null;
            bindingNavigatorAddNewItem.Enabled = false;
        }
    }
}
