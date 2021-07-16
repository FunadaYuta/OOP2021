
namespace Exercise1 {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btOpen = new System.Windows.Forms.Button();
            this.tbOutPut = new System.Windows.Forms.TextBox();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOpen2 = new System.Windows.Forms.Button();
            this.btOpen3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(475, 162);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(158, 61);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "ファイルを開く1";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbOutPut
            // 
            this.tbOutPut.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOutPut.Location = new System.Drawing.Point(12, 280);
            this.tbOutPut.Multiline = true;
            this.tbOutPut.Name = "tbOutPut";
            this.tbOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutPut.Size = new System.Drawing.Size(946, 301);
            this.tbOutPut.TabIndex = 1;
            // 
            // keyword
            // 
            this.keyword.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.keyword.Location = new System.Drawing.Point(158, 57);
            this.keyword.Multiline = true;
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(255, 61);
            this.keyword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(41, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "キーワード";
            // 
            // btOpen2
            // 
            this.btOpen2.Location = new System.Drawing.Point(662, 162);
            this.btOpen2.Name = "btOpen2";
            this.btOpen2.Size = new System.Drawing.Size(158, 61);
            this.btOpen2.TabIndex = 0;
            this.btOpen2.Text = "ファイルを開く2";
            this.btOpen2.UseVisualStyleBackColor = true;
            this.btOpen2.Click += new System.EventHandler(this.btOpen2_Click);
            // 
            // btOpen3
            // 
            this.btOpen3.Location = new System.Drawing.Point(853, 162);
            this.btOpen3.Name = "btOpen3";
            this.btOpen3.Size = new System.Drawing.Size(158, 61);
            this.btOpen3.TabIndex = 0;
            this.btOpen3.Text = "ファイルを開く3";
            this.btOpen3.UseVisualStyleBackColor = true;
            this.btOpen3.Click += new System.EventHandler(this.btOpen3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.tbOutPut);
            this.Controls.Add(this.btOpen3);
            this.Controls.Add(this.btOpen2);
            this.Controls.Add(this.btOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox tbOutPut;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOpen2;
        private System.Windows.Forms.Button btOpen3;
    }
}

