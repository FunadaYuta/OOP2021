
namespace StopWatch {
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
            this.tbstart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbstop = new System.Windows.Forms.Button();
            this.tbReset = new System.Windows.Forms.Button();
            this.btlap = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // tbstart
            // 
            this.tbstart.Location = new System.Drawing.Point(12, 26);
            this.tbstart.Name = "tbstart";
            this.tbstart.Size = new System.Drawing.Size(194, 76);
            this.tbstart.TabIndex = 0;
            this.tbstart.Text = "スタート";
            this.tbstart.UseVisualStyleBackColor = true;
            this.tbstart.Click += new System.EventHandler(this.tbstart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(127, 259);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 122);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbstop
            // 
            this.tbstop.Location = new System.Drawing.Point(254, 26);
            this.tbstop.Name = "tbstop";
            this.tbstop.Size = new System.Drawing.Size(194, 76);
            this.tbstop.TabIndex = 0;
            this.tbstop.Text = "ストップ";
            this.tbstop.UseVisualStyleBackColor = true;
            this.tbstop.Click += new System.EventHandler(this.tbstop_Click);
            // 
            // tbReset
            // 
            this.tbReset.Location = new System.Drawing.Point(12, 138);
            this.tbReset.Name = "tbReset";
            this.tbReset.Size = new System.Drawing.Size(194, 76);
            this.tbReset.TabIndex = 0;
            this.tbReset.Text = "リセット";
            this.tbReset.UseVisualStyleBackColor = true;
            this.tbReset.Click += new System.EventHandler(this.tbReset_Click);
            // 
            // btlap
            // 
            this.btlap.Location = new System.Drawing.Point(254, 138);
            this.btlap.Name = "btlap";
            this.btlap.Size = new System.Drawing.Size(194, 76);
            this.btlap.TabIndex = 0;
            this.btlap.Text = "ラップ";
            this.btlap.UseVisualStyleBackColor = true;
            this.btlap.Click += new System.EventHandler(this.btlap_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(493, 26);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 355);
            this.textBox2.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btlap);
            this.Controls.Add(this.tbReset);
            this.Controls.Add(this.tbstop);
            this.Controls.Add(this.tbstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbstart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tbstop;
        private System.Windows.Forms.Button tbReset;
        private System.Windows.Forms.Button btlap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

