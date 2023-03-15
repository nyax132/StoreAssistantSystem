namespace StoreAssistantSystem.Control
{
    partial class MainMenu
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
            setting_button = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button_ProductMasterRegistration = new Button();
            button2 = new Button();
            order_button = new Button();
            SuspendLayout();
            // 
            // setting_button
            // 
            setting_button.FlatAppearance.BorderColor = Color.Gray;
            setting_button.FlatAppearance.BorderSize = 3;
            setting_button.Location = new Point(268, 412);
            setting_button.Margin = new Padding(3, 4, 3, 4);
            setting_button.Name = "setting_button";
            setting_button.Size = new Size(245, 85);
            setting_button.TabIndex = 13;
            setting_button.Text = "設定";
            setting_button.UseVisualStyleBackColor = true;
            setting_button.Click += setting_button_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderColor = Color.Gray;
            button6.FlatAppearance.BorderSize = 3;
            button6.Font = new Font("メイリオ", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(268, 223);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(245, 85);
            button6.TabIndex = 12;
            button6.Text = "棚札発行処理";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.Gray;
            button5.FlatAppearance.BorderSize = 3;
            button5.Font = new Font("メイリオ", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(268, 131);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(245, 85);
            button5.TabIndex = 11;
            button5.Text = "在庫管理";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatAppearance.BorderSize = 3;
            button4.Font = new Font("メイリオ", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(268, 38);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(245, 85);
            button4.TabIndex = 10;
            button4.Text = "発注外処理";
            button4.UseVisualStyleBackColor = true;
            // 
            // button_ProductMasterRegistration
            // 
            button_ProductMasterRegistration.FlatAppearance.BorderColor = Color.Gray;
            button_ProductMasterRegistration.FlatAppearance.BorderSize = 3;
            button_ProductMasterRegistration.Font = new Font("メイリオ", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_ProductMasterRegistration.Location = new Point(20, 223);
            button_ProductMasterRegistration.Margin = new Padding(3, 4, 3, 4);
            button_ProductMasterRegistration.Name = "button_ProductMasterRegistration";
            button_ProductMasterRegistration.Size = new Size(242, 85);
            button_ProductMasterRegistration.TabIndex = 9;
            button_ProductMasterRegistration.Text = "商品マスター登録";
            button_ProductMasterRegistration.UseVisualStyleBackColor = true;
            button_ProductMasterRegistration.Click += button_ProductMasterRegistration_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 3;
            button2.Font = new Font("メイリオ", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(20, 131);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(242, 85);
            button2.TabIndex = 8;
            button2.Text = "商品マスター検索";
            button2.UseVisualStyleBackColor = true;
            // 
            // order_button
            // 
            order_button.FlatAppearance.BorderColor = Color.Gray;
            order_button.FlatAppearance.BorderSize = 3;
            order_button.Font = new Font("メイリオ", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            order_button.Location = new Point(20, 38);
            order_button.Margin = new Padding(3, 4, 3, 4);
            order_button.Name = "order_button";
            order_button.Size = new Size(242, 85);
            order_button.TabIndex = 7;
            order_button.Text = "発注処理";
            order_button.UseVisualStyleBackColor = true;
            order_button.Click += order_button_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(setting_button);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button_ProductMasterRegistration);
            Controls.Add(button2);
            Controls.Add(order_button);
            Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Size = new Size(539, 529);
            ResumeLayout(false);
        }

        #endregion

        private Button setting_button;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button_ProductMasterRegistration;
        private Button button2;
        private Button order_button;
    }
}
