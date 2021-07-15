
namespace Exercise01 {
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
            this.components = new System.ComponentModel.Container();
            this.btToday = new System.Windows.Forms.Button();
            this.tbDateDisp = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.StatusStrip();
            this.tssTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.a.SuspendLayout();
            this.SuspendLayout();
            // 
            // btToday
            // 
            this.btToday.Location = new System.Drawing.Point(191, 48);
            this.btToday.Name = "btToday";
            this.btToday.Size = new System.Drawing.Size(128, 79);
            this.btToday.TabIndex = 0;
            this.btToday.Text = "今日";
            this.btToday.UseVisualStyleBackColor = true;
            this.btToday.Click += new System.EventHandler(this.btToday_Click);
            // 
            // tbDateDisp
            // 
            this.tbDateDisp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDateDisp.Location = new System.Drawing.Point(337, 12);
            this.tbDateDisp.Multiline = true;
            this.tbDateDisp.Name = "tbDateDisp";
            this.tbDateDisp.Size = new System.Drawing.Size(428, 173);
            this.tbDateDisp.TabIndex = 1;
            // 
            // a
            // 
            this.a.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTimeLabel});
            this.a.Location = new System.Drawing.Point(0, 529);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(786, 22);
            this.a.TabIndex = 0;
            // 
            // tssTimeLabel
            // 
            this.tssTimeLabel.Name = "tssTimeLabel";
            this.tssTimeLabel.Size = new System.Drawing.Size(118, 17);
            this.tssTimeLabel.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 551);
            this.Controls.Add(this.a);
            this.Controls.Add(this.tbDateDisp);
            this.Controls.Add(this.btToday);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btToday;
        private System.Windows.Forms.TextBox tbDateDisp;
        private System.Windows.Forms.StatusStrip a;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssTimeLabel;
        private System.Windows.Forms.Timer tm;
    }
}

