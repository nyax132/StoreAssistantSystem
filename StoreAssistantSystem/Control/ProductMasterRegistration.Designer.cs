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
            SuspendLayout();
            // 
            // button_registration
            // 
            button_registration.BackColor = Color.FromArgb(255, 128, 128);
            button_registration.Location = new Point(194, 494);
            button_registration.Margin = new Padding(3, 4, 3, 4);
            button_registration.Name = "button_registration";
            button_registration.Size = new Size(145, 60);
            button_registration.TabIndex = 1;
            button_registration.Text = "登録";
            button_registration.UseVisualStyleBackColor = false;
            // 
            // button_backmenu
            // 
            button_backmenu.Location = new Point(345, 494);
            button_backmenu.Margin = new Padding(3, 4, 3, 4);
            button_backmenu.Name = "button_backmenu";
            button_backmenu.Size = new Size(145, 60);
            button_backmenu.TabIndex = 2;
            button_backmenu.Text = "戻る";
            button_backmenu.UseVisualStyleBackColor = true;
            button_backmenu.Click += button_backmenu_Click_1;
            // 
            // ProductMasterRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_registration);
            Controls.Add(button_backmenu);
            Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductMasterRegistration";
            Size = new Size(526, 602);
            ResumeLayout(false);
        }

        #endregion

        private Button button_registration;
        private Button button_backmenu;
    }
}
