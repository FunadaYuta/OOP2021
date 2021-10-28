using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

       
        //private void personBindingNavigatorSaveItem_Click_1(object sender, EventArgs e) {
        //    this.Validate();
        //    this.personBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.infosys202130DataSet);

        //}

        private void Form1_Load(object sender, EventArgs e) {
            personDataGridView.Columns[0].Visible = false;
            personDataGridView.Columns[1].HeaderText = "名前";
            personDataGridView.Columns[2].HeaderText = "誕生日";
            personDataGridView.Columns[3].HeaderText = "電話番号";
            personDataGridView.Columns[4].HeaderText = "メモ";
        }

        private void BtConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202130DataSet.Person' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.personTableAdapter.Fill(this.infosys202130DataSet.Person);
        }
        private void BtNameFilter_Click(object sender, EventArgs e) {
            this.personTableAdapter.FillByName(this.infosys202130DataSet.Person, TbNameSearch.Text);
        }

        private void BtSave_Click(object sender, EventArgs e) {
            //テキストボックスに入力した値を表に格納する
            personDataGridView.CurrentRow.Cells[1].Value = TbName.Text;
            personDataGridView.CurrentRow.Cells[2].Value = DtpDate.Value;
            personDataGridView.CurrentRow.Cells[3].Value = TbTelephone.Text;
            personDataGridView.CurrentRow.Cells[4].Value = TbMemo.Text;

            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202130DataSet);
        }

        private void personDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (personDataGridView.CurrentRow == null) return;
            TbName.Text = personDataGridView.CurrentRow.Cells[1].Value.ToString();
            DtpDate.Value = (DateTime)personDataGridView.CurrentRow.Cells[2].Value;
            TbTelephone.Text = personDataGridView.CurrentRow.Cells[3].Value.ToString();
            TbMemo.Text = personDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtBirthdayFilter__Click(object sender, EventArgs e) {
            this.personTableAdapter.FillByBirthday(this.infosys202130DataSet.Person, DtpBirthday.Value.ToString());
        }
    }
}
