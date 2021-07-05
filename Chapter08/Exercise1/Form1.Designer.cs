
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
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.BTAction = new System.Windows.Forms.Button();
            this.TBLeapYear = new System.Windows.Forms.TextBox();
            this.TBage = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TBOutput
            // 
            this.TBOutput.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TBOutput.Location = new System.Drawing.Point(176, 112);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(553, 34);
            this.TBOutput.TabIndex = 0;
            // 
            // BTAction
            // 
            this.BTAction.Location = new System.Drawing.Point(45, 101);
            this.BTAction.Name = "BTAction";
            this.BTAction.Size = new System.Drawing.Size(107, 45);
            this.BTAction.TabIndex = 1;
            this.BTAction.Text = "実行";
            this.BTAction.UseVisualStyleBackColor = true;
            this.BTAction.Click += new System.EventHandler(this.BTAction_Click);
            // 
            // TBLeapYear
            // 
            this.TBLeapYear.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TBLeapYear.Location = new System.Drawing.Point(176, 183);
            this.TBLeapYear.Name = "TBLeapYear";
            this.TBLeapYear.Size = new System.Drawing.Size(553, 34);
            this.TBLeapYear.TabIndex = 0;
            // 
            // TBage
            // 
            this.TBage.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TBage.Location = new System.Drawing.Point(176, 255);
            this.TBage.Name = "TBage";
            this.TBage.Size = new System.Drawing.Size(553, 34);
            this.TBage.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BTAction);
            this.Controls.Add(this.TBage);
            this.Controls.Add(this.TBLeapYear);
            this.Controls.Add(this.TBOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.Button BTAction;
        private System.Windows.Forms.TextBox TBLeapYear;
        private System.Windows.Forms.TextBox TBage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

