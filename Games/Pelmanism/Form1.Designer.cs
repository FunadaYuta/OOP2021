﻿
namespace Pelmanism {
    partial class FormGame {
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
            this.labelSec = new System.Windows.Forms.Label();
            this.labelGuidance = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Location = new System.Drawing.Point(12, 9);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(47, 12);
            this.labelSec.TabIndex = 0;
            this.labelSec.Text = "0秒経過";
            // 
            // labelGuidance
            // 
            this.labelGuidance.AutoSize = true;
            this.labelGuidance.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuidance.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelGuidance.ForeColor = System.Drawing.Color.Red;
            this.labelGuidance.Location = new System.Drawing.Point(78, 9);
            this.labelGuidance.Name = "labelGuidance";
            this.labelGuidance.Size = new System.Drawing.Size(41, 12);
            this.labelGuidance.TabIndex = 1;
            this.labelGuidance.Text = "label1";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(192, 276);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 311);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelGuidance);
            this.Controls.Add(this.labelSec);
            this.Name = "FormGame";
            this.Text = "神経衰弱";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelGuidance;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

