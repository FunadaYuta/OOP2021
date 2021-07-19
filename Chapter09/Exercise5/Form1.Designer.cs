
namespace Exercise5 {
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
            this.TbFBD = new System.Windows.Forms.TextBox();
            this.BtFolder = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // TbFBD
            // 
            this.TbFBD.Location = new System.Drawing.Point(108, 190);
            this.TbFBD.Multiline = true;
            this.TbFBD.Name = "TbFBD";
            this.TbFBD.Size = new System.Drawing.Size(586, 248);
            this.TbFBD.TabIndex = 0;
            // 
            // BtFolder
            // 
            this.BtFolder.Location = new System.Drawing.Point(197, 53);
            this.BtFolder.Name = "BtFolder";
            this.BtFolder.Size = new System.Drawing.Size(320, 91);
            this.BtFolder.TabIndex = 1;
            this.BtFolder.Text = "button1";
            this.BtFolder.UseVisualStyleBackColor = true;
            this.BtFolder.Click += new System.EventHandler(this.BtFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtFolder);
            this.Controls.Add(this.TbFBD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbFBD;
        private System.Windows.Forms.Button BtFolder;
        private System.Windows.Forms.FolderBrowserDialog FBD;
    }
}

