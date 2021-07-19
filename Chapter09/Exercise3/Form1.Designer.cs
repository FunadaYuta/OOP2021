
namespace Exercise3 {
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
            this.TbFirstFileName = new System.Windows.Forms.TextBox();
            this.TbLastFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtFileText = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TbFirstFileName
            // 
            this.TbFirstFileName.Location = new System.Drawing.Point(287, 88);
            this.TbFirstFileName.Multiline = true;
            this.TbFirstFileName.Name = "TbFirstFileName";
            this.TbFirstFileName.Size = new System.Drawing.Size(345, 37);
            this.TbFirstFileName.TabIndex = 0;
            // 
            // TbLastFileName
            // 
            this.TbLastFileName.Location = new System.Drawing.Point(287, 160);
            this.TbLastFileName.Multiline = true;
            this.TbLastFileName.Name = "TbLastFileName";
            this.TbLastFileName.Size = new System.Drawing.Size(345, 37);
            this.TbLastFileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(166, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "元";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(87, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "後ろに追加";
            // 
            // BtFileText
            // 
            this.BtFileText.Location = new System.Drawing.Point(223, 246);
            this.BtFileText.Name = "BtFileText";
            this.BtFileText.Size = new System.Drawing.Size(398, 163);
            this.BtFileText.TabIndex = 2;
            this.BtFileText.Text = "テキストを追加";
            this.BtFileText.UseVisualStyleBackColor = true;
            this.BtFileText.Click += new System.EventHandler(this.BtFileText_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtFileText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbLastFileName);
            this.Controls.Add(this.TbFirstFileName);
            this.Name = "Form1";
            this.Text = "textbo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbFirstFileName;
        private System.Windows.Forms.TextBox TbLastFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtFileText;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

