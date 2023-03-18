namespace StoreAssistantSystem.Control
{
    partial class ProductMasterRegistration
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
            button_registration = new Button();
            button_backmenu = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox_gondora = new TextBox();
            label9 = new Label();
            dateTimePicker_Dateofcommencementofhandling = new DateTimePicker();
            label6 = new Label();
            textBox_productname = new TextBox();
            label2 = new Label();
            textBox_jan = new TextBox();
            label1 = new Label();
            button_CompetitiveChecking = new Button();
            groupBox2 = new GroupBox();
            textBox_costprice = new TextBox();
            label5 = new Label();
            textBox_sellingprice = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            textBox_Perorderquantity = new TextBox();
            label7 = new Label();
            textBox_Minimumorderquantity = new TextBox();
            label8 = new Label();
            groupBox4 = new GroupBox();
            textBox_stock = new TextBox();
            label10 = new Label();
            checkBox_AllowOverwriting = new CheckBox();
            button_delete = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button_registration
            // 
            button_registration.BackColor = Color.FromArgb(128, 128, 255);
            button_registration.Location = new Point(267, 494);
            button_registration.Margin = new Padding(3, 4, 3, 4);
            button_registration.Name = "button_registration";
            button_registration.Size = new Size(110, 60);
            button_registration.TabIndex = 1;
            button_registration.Text = "登録";
            button_registration.UseVisualStyleBackColor = false;
            button_registration.Click += button_registration_Click;
            // 
            // button_backmenu
            // 
            button_backmenu.Location = new Point(383, 494);
            button_backmenu.Margin = new Padding(3, 4, 3, 4);
            button_backmenu.Name = "button_backmenu";
            button_backmenu.Size = new Size(107, 60);
            button_backmenu.TabIndex = 2;
            button_backmenu.Text = "戻る";
            button_backmenu.UseVisualStyleBackColor = true;
            button_backmenu.Click += button_backmenu_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("メイリオ", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(15, 9);
            label4.Name = "label4";
            label4.Size = new Size(175, 23);
            label4.TabIndex = 7;
            label4.Text = "～商品マスタ情報編集～";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_gondora);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateTimePicker_Dateofcommencementofhandling);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox_productname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_jan);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 166);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "商品情報";
            // 
            // textBox_gondora
            // 
            textBox_gondora.Location = new Point(249, 114);
            textBox_gondora.Name = "textBox_gondora";
            textBox_gondora.Size = new Size(169, 25);
            textBox_gondora.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(231, 93);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 6;
            label9.Text = "ゴンドラ";
            // 
            // dateTimePicker_Dateofcommencementofhandling
            // 
            dateTimePicker_Dateofcommencementofhandling.Location = new Point(249, 50);
            dateTimePicker_Dateofcommencementofhandling.Name = "dateTimePicker_Dateofcommencementofhandling";
            dateTimePicker_Dateofcommencementofhandling.Size = new Size(169, 25);
            dateTimePicker_Dateofcommencementofhandling.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 31);
            label6.Name = "label6";
            label6.Size = new Size(92, 18);
            label6.TabIndex = 4;
            label6.Text = "取り扱い開始日";
            // 
            // textBox_productname
            // 
            textBox_productname.Location = new Point(18, 114);
            textBox_productname.Name = "textBox_productname";
            textBox_productname.Size = new Size(169, 25);
            textBox_productname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 2;
            label2.Text = "商品名";
            // 
            // textBox_jan
            // 
            textBox_jan.Location = new Point(18, 52);
            textBox_jan.Name = "textBox_jan";
            textBox_jan.Size = new Size(169, 25);
            textBox_jan.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 0;
            label1.Text = "JAN🔑";
            // 
            // button_CompetitiveChecking
            // 
            button_CompetitiveChecking.BackColor = Color.FromArgb(128, 255, 128);
            button_CompetitiveChecking.Location = new Point(38, 494);
            button_CompetitiveChecking.Margin = new Padding(3, 4, 3, 4);
            button_CompetitiveChecking.Name = "button_CompetitiveChecking";
            button_CompetitiveChecking.Size = new Size(107, 60);
            button_CompetitiveChecking.TabIndex = 9;
            button_CompetitiveChecking.Text = "情報照会";
            button_CompetitiveChecking.UseVisualStyleBackColor = false;
            button_CompetitiveChecking.Click += button_CompetitiveChecking_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_costprice);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox_sellingprice);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(38, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(219, 178);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "値段";
            // 
            // textBox_costprice
            // 
            textBox_costprice.Location = new Point(16, 116);
            textBox_costprice.Name = "textBox_costprice";
            textBox_costprice.Size = new Size(169, 25);
            textBox_costprice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 95);
            label5.Name = "label5";
            label5.Size = new Size(56, 18);
            label5.TabIndex = 10;
            label5.Text = "仕入れ値";
            // 
            // textBox_sellingprice
            // 
            textBox_sellingprice.Location = new Point(16, 54);
            textBox_sellingprice.Name = "textBox_sellingprice";
            textBox_sellingprice.Size = new Size(169, 25);
            textBox_sellingprice.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(32, 18);
            label3.TabIndex = 8;
            label3.Text = "売価";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox_Perorderquantity);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox_Minimumorderquantity);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(271, 207);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(219, 178);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "発注情報";
            // 
            // textBox_Perorderquantity
            // 
            textBox_Perorderquantity.Location = new Point(16, 116);
            textBox_Perorderquantity.Name = "textBox_Perorderquantity";
            textBox_Perorderquantity.Size = new Size(169, 25);
            textBox_Perorderquantity.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 95);
            label7.Name = "label7";
            label7.Size = new Size(92, 18);
            label7.TabIndex = 10;
            label7.Text = "発注数量あたり";
            // 
            // textBox_Minimumorderquantity
            // 
            textBox_Minimumorderquantity.Location = new Point(16, 54);
            textBox_Minimumorderquantity.Name = "textBox_Minimumorderquantity";
            textBox_Minimumorderquantity.Size = new Size(169, 25);
            textBox_Minimumorderquantity.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 33);
            label8.Name = "label8";
            label8.Size = new Size(68, 18);
            label8.TabIndex = 8;
            label8.Text = "最低発注数";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox_stock);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(271, 391);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(219, 78);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "在庫";
            // 
            // textBox_stock
            // 
            textBox_stock.Location = new Point(16, 47);
            textBox_stock.Name = "textBox_stock";
            textBox_stock.Size = new Size(169, 25);
            textBox_stock.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 26);
            label10.Name = "label10";
            label10.Size = new Size(68, 18);
            label10.TabIndex = 0;
            label10.Text = "現在在庫数";
            // 
            // checkBox_AllowOverwriting
            // 
            checkBox_AllowOverwriting.AutoSize = true;
            checkBox_AllowOverwriting.Location = new Point(166, 447);
            checkBox_AllowOverwriting.Name = "checkBox_AllowOverwriting";
            checkBox_AllowOverwriting.Size = new Size(99, 22);
            checkBox_AllowOverwriting.TabIndex = 14;
            checkBox_AllowOverwriting.Text = "上書きを許可";
            checkBox_AllowOverwriting.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(255, 128, 128);
            button_delete.Location = new Point(151, 494);
            button_delete.Margin = new Padding(3, 4, 3, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(110, 60);
            button_delete.TabIndex = 15;
            button_delete.Text = "削除";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // ProductMasterRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_delete);
            Controls.Add(checkBox_AllowOverwriting);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button_CompetitiveChecking);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(button_registration);
            Controls.Add(button_backmenu);
            Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductMasterRegistration";
            Size = new Size(526, 602);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_registration;
        private Button button_backmenu;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox_jan;
        private Label label1;
        private Button button_CompetitiveChecking;
        private TextBox textBox_productname;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBox_costprice;
        private Label label5;
        private TextBox textBox_sellingprice;
        private Label label3;
        private DateTimePicker dateTimePicker_Dateofcommencementofhandling;
        private Label label6;
        private GroupBox groupBox3;
        private TextBox textBox_Perorderquantity;
        private Label label7;
        private TextBox textBox_Minimumorderquantity;
        private Label label8;
        private TextBox textBox_gondora;
        private Label label9;
        private GroupBox groupBox4;
        private TextBox textBox_stock;
        private Label label10;
        private CheckBox checkBox_AllowOverwriting;
        private Button button_delete;
    }
}
