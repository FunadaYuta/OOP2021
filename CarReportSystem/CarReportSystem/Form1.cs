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

            bindingNavigatorAddNewItem.Enabled = false;
            btUpdate.Enabled = false;

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

        //private void setMakerRadioButton(CarReport.MakerGroup mg) {
        //    switch (mg) {
        //        case CarReport.MakerGroup.トヨタ:
        //            rbToyota.Checked = true;
        //            break;
        //        case CarReport.MakerGroup.日産:
        //            rbNissan.Checked = true;
        //            break;
        //        case CarReport.MakerGroup.ホンダ:
        //            rbHonda.Checked = true;
        //            break;
        //        case CarReport.MakerGroup.スバル:
        //            rbSubaru.Checked = true;
        //            break;
        //        case CarReport.MakerGroup.外国車:
        //            rbImport.Checked = true;
        //            break;
        //        default:    //その他
        //            rbOther.Checked = true;
        //            break;
        //    }
        //}

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

            if (cbCarName.Text.Trim().Length == 0 || cbAuthor.Text.Trim().Length == 0) {
                ssErrorLabel.Text = "記録者と車名を入力してください";
                return;
            }

            //作成した記録者と車名をコンボボックスにセットする
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

            //入力した値をDataGridViewに格納する
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
            btConnect.Enabled = false;
            btUpdate.Enabled = true;
        }
       
        //DataGridViewの内容が変更された場合に呼び出される
        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {

            ssErrorLabel.Text = "";

            //何も選択していない場合は返す
            if (carReportDataGridView.CurrentRow == null)return;

            try {

                //データベースの値をテキストに格納する
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();
                setMakerRadioButton(carReportDataGridView.CurrentRow.Cells[3].Value.ToString());
                //setMakerRadioButton
                //    ((CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup),
                //    carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));
                //メーカー（文字列→列挙型）
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();

                //選択している行が正しく入力さている場合は新規作成が可能になるようにする
                if (cbCarName.Text.Trim().Length > 0　|| cbAuthor.Text.Trim().Length > 0) {
                    bindingNavigatorAddNewItem.Enabled = true;
                }

                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);
                
            }
            catch (InvalidCastException) {
                //データベースに画像がない場合は例外が起こるため、画像をNULLにして表示しない
                pbPicture.Image = null;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        // バイト配列をImageオブジェクトに変換
            public static Image ByteArrayToImage(byte[] b) {
            Image img = null;
            if(b.Length > 0) {
                ImageConverter imgconv = new ImageConverter();
                img = (Image)imgconv.ConvertFrom(b);
            }
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
        
        //新規作成ボタン処理
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {

            //テキストをクリアにして新規作成ボタンを押せなくする
            TextClear();
            bindingNavigatorAddNewItem.Enabled = false;
        }

        //テキストをすべてクリアにする
        private void TextClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.ResetText();
            rbOther.Checked = true;
            cbCarName.ResetText();
            tbReport.Clear();
            pbPicture.Image = null;
        }

        //なんかこれがないとエラーが起きるから必要
        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }
    }
}
