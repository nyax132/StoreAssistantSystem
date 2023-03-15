namespace StoreAssistantSystem.Control
{
    partial class OrderMenu
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
            textBox_jan = new TextBox();
            button_read = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label_CurrentInventory = new Label();
            label_gondora = new Label();
            label_Dateofcommencementofhandling = new Label();
            label_costprice = new Label();
            label_sellingprice = new Label();
            label_Perorderquantity = new Label();
            label_Minimumorderquantity = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox_LastOrderDate = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker_orderdate = new DateTimePicker();
            button_backmenu = new Button();
            button_registration = new Button();
            productname_label = new Label();
            button_registrationhistory = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox_jan
            // 
            textBox_jan.Location = new Point(35, 36);
            textBox_jan.Margin = new Padding(3, 4, 3, 4);
            textBox_jan.Name = "textBox_jan";
            textBox_jan.Size = new Size(360, 25);
            textBox_jan.TabIndex = 1;
            // 
            // button_read
            // 
            button_read.Location = new Point(401, 36);
            button_read.Margin = new Padding(3, 4, 3, 4);
            button_read.Name = "button_read";
            button_read.Size = new Size(83, 25);
            button_read.TabIndex = 2;
            button_read.Text = "読み込み";
            button_read.UseVisualStyleBackColor = true;
            button_read.Click += button_read_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox_LastOrderDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker_orderdate);
            groupBox1.Location = new Point(35, 103);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(455, 384);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "発注";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_CurrentInventory);
            groupBox2.Controls.Add(label_gondora);
            groupBox2.Controls.Add(label_Dateofcommencementofhandling);
            groupBox2.Controls.Add(label_costprice);
            groupBox2.Controls.Add(label_sellingprice);
            groupBox2.Controls.Add(label_Perorderquantity);
            groupBox2.Controls.Add(label_Minimumorderquantity);
            groupBox2.Location = new Point(8, 216);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(441, 161);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "マスター情報";
            // 
            // label_CurrentInventory
            // 
            label_CurrentInventory.AutoSize = true;
            label_CurrentInventory.Location = new Point(224, 102);
            label_CurrentInventory.Name = "label_CurrentInventory";
            label_CurrentInventory.Size = new Size(68, 18);
            label_CurrentInventory.TabIndex = 6;
            label_CurrentInventory.Text = "現在在庫数";
            // 
            // label_gondora
            // 
            label_gondora.AutoSize = true;
            label_gondora.Location = new Point(224, 62);
            label_gondora.Name = "label_gondora";
            label_gondora.Size = new Size(56, 18);
            label_gondora.TabIndex = 5;
            label_gondora.Text = "ゴンドラ";
            // 
            // label_Dateofcommencementofhandling
            // 
            label_Dateofcommencementofhandling.AutoSize = true;
            label_Dateofcommencementofhandling.Location = new Point(224, 34);
            label_Dateofcommencementofhandling.Name = "label_Dateofcommencementofhandling";
            label_Dateofcommencementofhandling.Size = new Size(92, 18);
            label_Dateofcommencementofhandling.TabIndex = 4;
            label_Dateofcommencementofhandling.Text = "取り扱い開始日";
            // 
            // label_costprice
            // 
            label_costprice.AutoSize = true;
            label_costprice.Location = new Point(42, 127);
            label_costprice.Name = "label_costprice";
            label_costprice.Size = new Size(56, 18);
            label_costprice.TabIndex = 3;
            label_costprice.Text = "仕入れ値";
            // 
            // label_sellingprice
            // 
            label_sellingprice.AutoSize = true;
            label_sellingprice.Location = new Point(66, 102);
            label_sellingprice.Name = "label_sellingprice";
            label_sellingprice.Size = new Size(32, 18);
            label_sellingprice.TabIndex = 2;
            label_sellingprice.Text = "売価";
            // 
            // label_Perorderquantity
            // 
            label_Perorderquantity.AutoSize = true;
            label_Perorderquantity.Location = new Point(6, 62);
            label_Perorderquantity.Name = "label_Perorderquantity";
            label_Perorderquantity.Size = new Size(92, 18);
            label_Perorderquantity.TabIndex = 1;
            label_Perorderquantity.Text = "発注数量あたり";
            // 
            // label_Minimumorderquantity
            // 
            label_Minimumorderquantity.AutoSize = true;
            label_Minimumorderquantity.Location = new Point(30, 34);
            label_Minimumorderquantity.Name = "label_Minimumorderquantity";
            label_Minimumorderquantity.Size = new Size(68, 18);
            label_Minimumorderquantity.TabIndex = 0;
            label_Minimumorderquantity.Text = "最低発注数";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(23, 138);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 25);
            numericUpDown1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 116);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 6;
            label3.Text = "-個数-";
            // 
            // button2
            // 
            button2.Location = new Point(374, 138);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 34);
            button2.TabIndex = 5;
            button2.Text = "発注履歴";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(374, 180);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 4;
            button1.Text = "到着予定日";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox_LastOrderDate
            // 
            textBox_LastOrderDate.Location = new Point(271, 64);
            textBox_LastOrderDate.Margin = new Padding(3, 4, 3, 4);
            textBox_LastOrderDate.Name = "textBox_LastOrderDate";
            textBox_LastOrderDate.ReadOnly = true;
            textBox_LastOrderDate.Size = new Size(146, 25);
            textBox_LastOrderDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 42);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 2;
            label2.Text = "-前回発注日-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 1;
            label1.Text = "-発注日-";
            // 
            // dateTimePicker_orderdate
            // 
            dateTimePicker_orderdate.Location = new Point(23, 64);
            dateTimePicker_orderdate.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_orderdate.Name = "dateTimePicker_orderdate";
            dateTimePicker_orderdate.Size = new Size(146, 25);
            dateTimePicker_orderdate.TabIndex = 0;
            // 
            // button_backmenu
            // 
            button_backmenu.Location = new Point(345, 494);
            button_backmenu.Margin = new Padding(3, 4, 3, 4);
            button_backmenu.Name = "button_backmenu";
            button_backmenu.Size = new Size(145, 60);
            button_backmenu.TabIndex = 0;
            button_backmenu.Text = "戻る";
            button_backmenu.UseVisualStyleBackColor = true;
            button_backmenu.Click += button1_Click;
            // 
            // button_registration
            // 
            button_registration.BackColor = Color.FromArgb(255, 128, 128);
            button_registration.Location = new Point(194, 495);
            button_registration.Margin = new Padding(3, 4, 3, 4);
            button_registration.Name = "button_registration";
            button_registration.Size = new Size(145, 60);
            button_registration.TabIndex = 0;
            button_registration.Text = "登録";
            button_registration.UseVisualStyleBackColor = false;
            // 
            // productname_label
            // 
            productname_label.AutoSize = true;
            productname_label.Location = new Point(41, 68);
            productname_label.Name = "productname_label";
            productname_label.Size = new Size(44, 18);
            productname_label.TabIndex = 4;
            productname_label.Text = "商品名";
            // 
            // button_registrationhistory
            // 
            button_registrationhistory.BackColor = Color.FromArgb(128, 255, 128);
            button_registrationhistory.Location = new Point(43, 495);
            button_registrationhistory.Margin = new Padding(3, 4, 3, 4);
            button_registrationhistory.Name = "button_registrationhistory";
            button_registrationhistory.Size = new Size(145, 60);
            button_registrationhistory.TabIndex = 5;
            button_registrationhistory.Text = "登録履歴";
            button_registrationhistory.UseVisualStyleBackColor = false;
            // 
            // OrderMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_registrationhistory);
            Controls.Add(productname_label);
            Controls.Add(button_registration);
            Controls.Add(button_read);
            Controls.Add(groupBox1);
            Controls.Add(button_backmenu);
            Controls.Add(textBox_jan);
            Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderMenu";
            Size = new Size(526, 602);
            Load += OrderMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_jan;
        private Button button_read;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dateTimePicker_orderdate;
        private Button button_backmenu;
        private Button button_registration;
        private TextBox textBox_LastOrderDate;
        private Label label2;
        private Label productname_label;
        private Button button_registrationhistory;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Label label_Minimumorderquantity;
        private Label label_Perorderquantity;
        private Label label_Dateofcommencementofhandling;
        private Label label_costprice;
        private Label label_sellingprice;
        private Label label_gondora;
        private Label label_CurrentInventory;
    }
}
