
namespace WeatherApp {
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
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("東京 ");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("大島");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("八丈島 ");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("父島");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("東京", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("横浜");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("小田原");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("神奈川", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("さいたま");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("熊谷");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("秩父");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("埼玉", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("千葉");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("銚子");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("館山");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("千葉", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("水戸");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("土浦");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("茨木", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("宇都宮");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("太田原");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("栃木", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("前橋");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("みなかみ");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("群馬", new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("関東地方", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode34,
            treeNode38,
            treeNode42,
            treeNode45,
            treeNode48,
            treeNode51});
            this.WeatherTextBox = new System.Windows.Forms.TextBox();
            this.AreaTree = new System.Windows.Forms.TreeView();
            this.AreaButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // WeatherTextBox
            // 
            this.WeatherTextBox.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeatherTextBox.Location = new System.Drawing.Point(298, 12);
            this.WeatherTextBox.Multiline = true;
            this.WeatherTextBox.Name = "WeatherTextBox";
            this.WeatherTextBox.Size = new System.Drawing.Size(519, 486);
            this.WeatherTextBox.TabIndex = 3;
            // 
            // AreaTree
            // 
            this.AreaTree.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AreaTree.Location = new System.Drawing.Point(43, 96);
            this.AreaTree.Name = "AreaTree";
            treeNode27.Name = "4410";
            treeNode27.Text = "東京 ";
            treeNode28.Name = "4420";
            treeNode28.Text = "大島";
            treeNode29.Name = "4430";
            treeNode29.Text = "八丈島 ";
            treeNode30.Name = "4440";
            treeNode30.Text = "父島";
            treeNode31.Name = "tokyo";
            treeNode31.Text = "東京";
            treeNode32.Name = "4610";
            treeNode32.Text = "横浜";
            treeNode33.Name = "4620";
            treeNode33.Text = "小田原";
            treeNode34.Name = "kanagawa";
            treeNode34.Text = "神奈川";
            treeNode35.Name = "4310";
            treeNode35.Text = "さいたま";
            treeNode36.Name = "4320";
            treeNode36.Text = "熊谷";
            treeNode37.Name = "4330";
            treeNode37.Text = "秩父";
            treeNode38.Name = "saitama";
            treeNode38.Text = "埼玉";
            treeNode39.Name = "4510";
            treeNode39.Text = "千葉";
            treeNode40.Name = "4520";
            treeNode40.Text = "銚子";
            treeNode41.Name = "4530";
            treeNode41.Text = "館山";
            treeNode42.Name = "tiba";
            treeNode42.Text = "千葉";
            treeNode43.Name = "4010";
            treeNode43.Text = "水戸";
            treeNode44.Name = "4020";
            treeNode44.Text = "土浦";
            treeNode45.Name = "ibaragi";
            treeNode45.Text = "茨木";
            treeNode46.Name = "4110";
            treeNode46.Text = "宇都宮";
            treeNode47.Name = "4120";
            treeNode47.Text = "太田原";
            treeNode48.Name = "totigi";
            treeNode48.Text = "栃木";
            treeNode49.Name = "4210";
            treeNode49.Text = "前橋";
            treeNode50.Name = "4220";
            treeNode50.Text = "みなかみ";
            treeNode51.Name = "gunma";
            treeNode51.Text = "群馬";
            treeNode52.Name = "kantou";
            treeNode52.Text = "関東地方";
            this.AreaTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode52});
            this.AreaTree.Size = new System.Drawing.Size(215, 402);
            this.AreaTree.TabIndex = 4;
            // 
            // AreaButton
            // 
            this.AreaButton.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AreaButton.Location = new System.Drawing.Point(43, 12);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(210, 48);
            this.AreaButton.TabIndex = 5;
            this.AreaButton.Text = "地域を選択";
            this.AreaButton.UseVisualStyleBackColor = true;
            this.AreaButton.Click += new System.EventHandler(this.AreaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 512);
            this.Controls.Add(this.AreaButton);
            this.Controls.Add(this.AreaTree);
            this.Controls.Add(this.WeatherTextBox);
            this.Name = "Form1";
            this.Text = "uti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox WeatherTextBox;
        private System.Windows.Forms.TreeView AreaTree;
        private System.Windows.Forms.Button AreaButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

