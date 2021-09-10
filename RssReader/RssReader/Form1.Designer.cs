
namespace RssReader {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WebSiteOpen = new System.Windows.Forms.Button();
            this.btNextTitle = new System.Windows.Forms.Button();
            this.lbdescription = new System.Windows.Forms.Label();
            this.lburl = new System.Windows.Forms.Label();
            this.lbpubdata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(179, 20);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(567, 31);
            this.tbUrl.TabIndex = 1;
            // 
            // lbTitles
            // 
            this.lbTitles.BackColor = System.Drawing.SystemColors.Window;
            this.lbTitles.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTitles.ItemHeight = 16;
            this.lbTitles.Location = new System.Drawing.Point(12, 105);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(312, 548);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.Click += new System.EventHandler(this.lbTitles_Click);
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRead.Location = new System.Drawing.Point(761, 20);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(99, 31);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "記事を選択↓↓";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(339, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "投稿時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(339, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(339, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "内容";
            // 
            // WebSiteOpen
            // 
            this.WebSiteOpen.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WebSiteOpen.Location = new System.Drawing.Point(343, 133);
            this.WebSiteOpen.Name = "WebSiteOpen";
            this.WebSiteOpen.Size = new System.Drawing.Size(162, 70);
            this.WebSiteOpen.TabIndex = 11;
            this.WebSiteOpen.Text = "Webサイトの表示";
            this.WebSiteOpen.UseVisualStyleBackColor = true;
            this.WebSiteOpen.Click += new System.EventHandler(this.WebSiteOpen_Click);
            // 
            // btNextTitle
            // 
            this.btNextTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNextTitle.Location = new System.Drawing.Point(177, 57);
            this.btNextTitle.Name = "btNextTitle";
            this.btNextTitle.Size = new System.Drawing.Size(124, 45);
            this.btNextTitle.TabIndex = 13;
            this.btNextTitle.Text = "次の記事";
            this.btNextTitle.UseVisualStyleBackColor = true;
            this.btNextTitle.Click += new System.EventHandler(this.btNextTitle_Click);
            // 
            // lbdescription
            // 
            this.lbdescription.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbdescription.Location = new System.Drawing.Point(464, 448);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(763, 201);
            this.lbdescription.TabIndex = 14;
            // 
            // lburl
            // 
            this.lburl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lburl.Location = new System.Drawing.Point(465, 348);
            this.lburl.Name = "lburl";
            this.lburl.Size = new System.Drawing.Size(684, 41);
            this.lburl.TabIndex = 15;
            // 
            // lbpubdata
            // 
            this.lbpubdata.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbpubdata.Location = new System.Drawing.Point(465, 255);
            this.lbpubdata.Name = "lbpubdata";
            this.lbpubdata.Size = new System.Drawing.Size(684, 41);
            this.lbpubdata.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1250, 671);
            this.Controls.Add(this.lbpubdata);
            this.Controls.Add(this.lburl);
            this.Controls.Add(this.lbdescription);
            this.Controls.Add(this.btNextTitle);
            this.Controls.Add(this.WebSiteOpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "32141";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button WebSiteOpen;
        private System.Windows.Forms.Button btNextTitle;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.Label lburl;
        private System.Windows.Forms.Label lbpubdata;
    }
}

