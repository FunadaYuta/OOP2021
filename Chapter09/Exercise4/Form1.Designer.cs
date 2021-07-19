
namespace Exercise4 {
    partial class Form1 {
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
            this.BtFilePath = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.TbDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtFilePath
            // 
            this.BtFilePath.Location = new System.Drawing.Point(234, 288);
            this.BtFilePath.Name = "BtFilePath";
            this.BtFilePath.Size = new System.Drawing.Size(320, 103);
            this.BtFilePath.TabIndex = 0;
            this.BtFilePath.Text = "元のファイルを選択してコピーー！";
            this.BtFilePath.UseVisualStyleBackColor = true;
            this.BtFilePath.Click += new System.EventHandler(this.BtFilePath_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // TbDirectory
            // 
            this.TbDirectory.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TbDirectory.Location = new System.Drawing.Point(102, 134);
            this.TbDirectory.Multiline = true;
            this.TbDirectory.Name = "TbDirectory";
            this.TbDirectory.Size = new System.Drawing.Size(641, 129);
            this.TbDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(158, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "コピーするディレクトリ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbDirectory);
            this.Controls.Add(this.BtFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtFilePath;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.TextBox TbDirectory;
        private System.Windows.Forms.Label label1;
    }
}

