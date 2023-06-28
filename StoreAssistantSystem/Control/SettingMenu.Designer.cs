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
            button_apply = new Button();
            groupBox1 = new GroupBox();
            textBox_port = new TextBox();
            label2 = new Label();
            textBox_ip = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            button_back = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button_apply
            // 
            button_apply.BackColor = Color.LightCoral;
            button_apply.FlatAppearance.BorderColor = Color.Gray;
            button_apply.FlatAppearance.BorderSize = 3;
            button_apply.Location = new Point(279, 412);
            button_apply.Margin = new Padding(3, 4, 3, 4);
            button_apply.Name = "button_apply";
            button_apply.Size = new Size(245, 85);
            button_apply.TabIndex = 14;
            button_apply.Text = "適用";
            button_apply.UseVisualStyleBackColor = false;
            button_apply.Click += button_apply_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_port);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_ip);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(237, 166);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "通信";
            // 
            // textBox_port
            // 
            textBox_port.Location = new Point(52, 113);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(136, 25);
            textBox_port.TabIndex = 3;
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
            // textBox_ip
            // 
            textBox_ip.Location = new Point(52, 51);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.Size = new Size(136, 25);
            textBox_ip.TabIndex = 1;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 390);
            label3.Name = "label3";
            label3.Size = new Size(248, 18);
            label3.TabIndex = 17;
            label3.Text = "※適用するにはアプリを再起動してください";
            // 
            // button_back
            // 
            button_back.FlatAppearance.BorderColor = Color.Gray;
            button_back.FlatAppearance.BorderSize = 3;
            button_back.Location = new Point(12, 412);
            button_back.Margin = new Padding(3, 4, 3, 4);
            button_back.Name = "button_back";
            button_back.Size = new Size(245, 85);
            button_back.TabIndex = 18;
            button_back.Text = "戻る";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // SettingMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_back);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(button_apply);
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

        private Button button_apply;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox_port;
        private Label label2;
        private TextBox textBox_ip;
        private Label label1;
        private Label label3;
        private Button button_back;
    }
}
