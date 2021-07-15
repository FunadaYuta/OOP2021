
namespace CarReportSystem {
    partial class fmMain {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.dgvRegistData = new System.Windows.Forms.DataGridView();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.GbMaker = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btEDataAdd = new System.Windows.Forms.Button();
            this.btDataDelete = new System.Windows.Forms.Button();
            this.btDataCorrect = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.pbPictureDelete = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ofdPictureOpen = new System.Windows.Forms.OpenFileDialog();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.GbMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistData
            // 
            this.dgvRegistData.AllowUserToAddRows = false;
            this.dgvRegistData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistData.Location = new System.Drawing.Point(85, 300);
            this.dgvRegistData.Name = "dgvRegistData";
            this.dgvRegistData.RowTemplate.Height = 21;
            this.dgvRegistData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistData.Size = new System.Drawing.Size(784, 211);
            this.dgvRegistData.TabIndex = 0;
            this.dgvRegistData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRegistData_CellClick);
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(85, 125);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(121, 20);
            this.cbCarName.TabIndex = 1;
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(559, 45);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(310, 200);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 2;
            this.pbPicture.TabStop = false;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(85, 45);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(121, 20);
            this.cbAuthor.TabIndex = 1;
            // 
            // GbMaker
            // 
            this.GbMaker.Controls.Add(this.rbOther);
            this.GbMaker.Controls.Add(this.rbSubaru);
            this.GbMaker.Controls.Add(this.rbImport);
            this.GbMaker.Controls.Add(this.rbHonda);
            this.GbMaker.Controls.Add(this.rbNissan);
            this.GbMaker.Controls.Add(this.rbToyota);
            this.GbMaker.Location = new System.Drawing.Point(85, 72);
            this.GbMaker.Name = "GbMaker";
            this.GbMaker.Size = new System.Drawing.Size(344, 36);
            this.GbMaker.TabIndex = 4;
            this.GbMaker.TabStop = false;
            this.GbMaker.Tag = "";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Checked = true;
            this.rbOther.Location = new System.Drawing.Point(280, 14);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 9;
            this.rbOther.TabStop = true;
            this.rbOther.Tag = "5";
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(169, 14);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 9;
            this.rbSubaru.Tag = "3";
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            this.rbImport.AutoSize = true;
            this.rbImport.Location = new System.Drawing.Point(227, 14);
            this.rbImport.Name = "rbImport";
            this.rbImport.Size = new System.Drawing.Size(47, 16);
            this.rbImport.TabIndex = 9;
            this.rbImport.Tag = "4";
            this.rbImport.Text = "外車";
            this.rbImport.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(112, 14);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 9;
            this.rbHonda.Tag = "2";
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(59, 14);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 9;
            this.rbNissan.Tag = "1";
            this.rbNissan.Text = "日産\r\n";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 14);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 9;
            this.rbToyota.Tag = "0";
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(85, 151);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(452, 143);
            this.tbReport.TabIndex = 5;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 327);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(67, 43);
            this.btOpen.TabIndex = 6;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 385);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(67, 43);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btEDataAdd
            // 
            this.btEDataAdd.Location = new System.Drawing.Point(571, 251);
            this.btEDataAdd.Name = "btEDataAdd";
            this.btEDataAdd.Size = new System.Drawing.Size(123, 43);
            this.btEDataAdd.TabIndex = 6;
            this.btEDataAdd.Text = "追加";
            this.btEDataAdd.UseVisualStyleBackColor = true;
            this.btEDataAdd.Click += new System.EventHandler(this.BtEDataAdd_Click);
            // 
            // btDataDelete
            // 
            this.btDataDelete.Location = new System.Drawing.Point(796, 261);
            this.btDataDelete.Name = "btDataDelete";
            this.btDataDelete.Size = new System.Drawing.Size(73, 33);
            this.btDataDelete.TabIndex = 6;
            this.btDataDelete.Text = "削除";
            this.btDataDelete.UseVisualStyleBackColor = true;
            this.btDataDelete.Click += new System.EventHandler(this.BtDataDelete_Click);
            // 
            // btDataCorrect
            // 
            this.btDataCorrect.Location = new System.Drawing.Point(717, 261);
            this.btDataCorrect.Name = "btDataCorrect";
            this.btDataCorrect.Size = new System.Drawing.Size(73, 33);
            this.btDataCorrect.TabIndex = 6;
            this.btDataCorrect.Text = "修正";
            this.btDataCorrect.UseVisualStyleBackColor = true;
            this.btDataCorrect.Click += new System.EventHandler(this.BtDataCorrect_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(806, 517);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(63, 22);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(581, 9);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(130, 30);
            this.btPictureOpen.TabIndex = 6;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.BtPictureOpen_Click);
            // 
            // pbPictureDelete
            // 
            this.pbPictureDelete.Location = new System.Drawing.Point(717, 9);
            this.pbPictureDelete.Name = "pbPictureDelete";
            this.pbPictureDelete.Size = new System.Drawing.Size(130, 30);
            this.pbPictureDelete.TabIndex = 6;
            this.pbPictureDelete.Text = "削除";
            this.pbPictureDelete.UseVisualStyleBackColor = true;
            this.pbPictureDelete.Click += new System.EventHandler(this.PbPictureDelete_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(85, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(29, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(9, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "記事一覧：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(13, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "レポート：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(530, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "画像：";
            // 
            // ofdPictureOpen
            // 
            this.ofdPictureOpen.FileName = "openFileDialog1";
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 547);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDataDelete);
            this.Controls.Add(this.btDataCorrect);
            this.Controls.Add(this.pbPictureDelete);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btEDataAdd);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.GbMaker);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.dgvRegistData);
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.GbMaker.ResumeLayout(false);
            this.GbMaker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistData;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.GroupBox GbMaker;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEDataAdd;
        private System.Windows.Forms.Button btDataDelete;
        private System.Windows.Forms.Button btDataCorrect;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.Button pbPictureDelete;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofdPictureOpen;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
    }
}

