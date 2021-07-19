
namespace Exercise2 {
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
            this.TbNewFile = new System.Windows.Forms.TextBox();
            this.BtFileOpen = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.BTSFD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbNewFile
            // 
            this.TbNewFile.Location = new System.Drawing.Point(54, 133);
            this.TbNewFile.Multiline = true;
            this.TbNewFile.Name = "TbNewFile";
            this.TbNewFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbNewFile.Size = new System.Drawing.Size(717, 305);
            this.TbNewFile.TabIndex = 0;
            // 
            // BtFileOpen
            // 
            this.BtFileOpen.Location = new System.Drawing.Point(54, 44);
            this.BtFileOpen.Name = "BtFileOpen";
            this.BtFileOpen.Size = new System.Drawing.Size(169, 61);
            this.BtFileOpen.TabIndex = 1;
            this.BtFileOpen.Text = "ファイル読み込み";
            this.BtFileOpen.UseVisualStyleBackColor = true;
            this.BtFileOpen.Click += new System.EventHandler(this.BtFileOpen_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // BTSFD
            // 
            this.BTSFD.Location = new System.Drawing.Point(283, 44);
            this.BTSFD.Name = "BTSFD";
            this.BTSFD.Size = new System.Drawing.Size(157, 61);
            this.BTSFD.TabIndex = 2;
            this.BTSFD.Text = "ファイルに保存";
            this.BTSFD.UseVisualStyleBackColor = true;
            this.BTSFD.Click += new System.EventHandler(this.BTSFD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTSFD);
            this.Controls.Add(this.BtFileOpen);
            this.Controls.Add(this.TbNewFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNewFile;
        private System.Windows.Forms.Button BtFileOpen;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BTSFD;
    }
}

