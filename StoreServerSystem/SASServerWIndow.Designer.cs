namespace StoreServerSystem
{
    partial class SASServerWIndow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            loglistBox = new ListBox();
            button_serverstop = new Button();
            button_serverstart = new Button();
            button_databaseoptimization = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            textBox_serverport = new TextBox();
            label3 = new Label();
            textBox_serveradress = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "SASサーバー";
            // 
            // loglistBox
            // 
            loglistBox.FormattingEnabled = true;
            loglistBox.ItemHeight = 15;
            loglistBox.Location = new Point(12, 214);
            loglistBox.Name = "loglistBox";
            loglistBox.Size = new Size(389, 199);
            loglistBox.TabIndex = 1;
            // 
            // button_serverstop
            // 
            button_serverstop.BackColor = Color.FromArgb(255, 128, 128);
            button_serverstop.Location = new Point(12, 177);
            button_serverstop.Name = "button_serverstop";
            button_serverstop.Size = new Size(192, 31);
            button_serverstop.TabIndex = 2;
            button_serverstop.Text = "サーバーストップ";
            button_serverstop.UseVisualStyleBackColor = false;
            button_serverstop.Click += button_serverstop_Click;
            // 
            // button_serverstart
            // 
            button_serverstart.BackColor = Color.FromArgb(128, 255, 128);
            button_serverstart.Location = new Point(209, 177);
            button_serverstart.Name = "button_serverstart";
            button_serverstart.Size = new Size(192, 31);
            button_serverstart.TabIndex = 3;
            button_serverstart.Text = "サーバー開始";
            button_serverstart.UseVisualStyleBackColor = false;
            button_serverstart.Click += button_serverstart_Click;
            // 
            // button_databaseoptimization
            // 
            button_databaseoptimization.Location = new Point(12, 52);
            button_databaseoptimization.Name = "button_databaseoptimization";
            button_databaseoptimization.Size = new Size(192, 28);
            button_databaseoptimization.TabIndex = 4;
            button_databaseoptimization.Text = "データベース最適化";
            button_databaseoptimization.UseVisualStyleBackColor = true;
            button_databaseoptimization.Click += button_databaseoptimization_Click;
            // 
            // button4
            // 
            button4.Location = new Point(209, 52);
            button4.Name = "button4";
            button4.Size = new Size(192, 28);
            button4.TabIndex = 5;
            button4.Text = "List削除";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_serverport);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_serveradress);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 85);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "設定";
            // 
            // textBox_serverport
            // 
            textBox_serverport.Location = new Point(252, 46);
            textBox_serverport.Name = "textBox_serverport";
            textBox_serverport.Size = new Size(131, 23);
            textBox_serverport.TabIndex = 3;
            textBox_serverport.Text = "55555";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 28);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 2;
            label3.Text = "サーバーポート番号";
            // 
            // textBox_serveradress
            // 
            textBox_serveradress.Location = new Point(61, 46);
            textBox_serveradress.Name = "textBox_serveradress";
            textBox_serveradress.Size = new Size(131, 23);
            textBox_serveradress.TabIndex = 1;
            textBox_serveradress.Text = "127.0.0.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 0;
            label2.Text = "サーバーIPアドレス";
            // 
            // SASServerWIndow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(413, 416);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button_databaseoptimization);
            Controls.Add(button_serverstart);
            Controls.Add(button_serverstop);
            Controls.Add(loglistBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SASServerWIndow";
            Text = "StoreServerSystem";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_serverstop;
        private Button button_serverstart;
        private Button button_databaseoptimization;
        private Button button4;
        public ListBox loglistBox;
        private GroupBox groupBox1;
        private TextBox textBox_serverport;
        private Label label3;
        private TextBox textBox_serveradress;
        private Label label2;
    }
}