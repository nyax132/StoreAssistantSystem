namespace StoreAssistantSystem.Control
{
    partial class SettingMenu
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            button_enter = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button_enter
            // 
            button_enter.FlatAppearance.BorderColor = Color.Gray;
            button_enter.FlatAppearance.BorderSize = 3;
            button_enter.Location = new Point(268, 412);
            button_enter.Margin = new Padding(3, 4, 3, 4);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(245, 85);
            button_enter.TabIndex = 14;
            button_enter.Text = "決定";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_enter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 194);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "通信";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("メイリオ", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 16;
            label4.Text = "～設定～";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(68, 18);
            label1.TabIndex = 0;
            label1.Text = "IPアドレス";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 25);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 2;
            label2.Text = "ポート番号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(52, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 25);
            textBox2.TabIndex = 3;
            // 
            // SettingMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(button_enter);
            Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SettingMenu";
            Size = new Size(539, 529);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_enter;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}
