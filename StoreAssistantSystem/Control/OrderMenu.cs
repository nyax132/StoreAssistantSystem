namespace StoreAssistantSystem.Control
{
    public partial class OrderMenu : UserControl
    {
        private int jan;
        public OrderMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainmenu = new MainMenu();
            Program.SasWindow.TransitionControl(mainmenu);

        }

        private async void button_read_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_jan.Text) || !Components.IsOnlyAlphanumeric2(textBox_jan.Text))
            {
                return;
            }

            var result = await TcpClient.CommunicationToServer("productmaster serachjan " + textBox_jan.Text);
            if (result == "notfound")
            {
                Program.SasWindow?.StatusMessage("商品が見つかりませんでした。", true);
                return;
            }

            SetData(result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        }

        /// <summary>
        /// 情報をFormに表示します。
        /// </summary>
        /// <param name="datas"></param>
        private void SetData(string[] datas)
        {
            try
            {
                jan = int.Parse(datas[0]);
                productname_label.Text = datas[1];
                label_costprice.Text = "仕入れ値" + "　" + datas[2];
                label_sellingprice.Text = "売価" + "　" + datas[3];
                label_Minimumorderquantity.Text = "最低発注数" + "　" + datas[4];
                label_Perorderquantity.Text = "発注数量あたり" + "　" + datas[5];
                label_CurrentInventory.Text = "現在在庫数" + "　" + datas[6];
                label_Dateofcommencementofhandling.Text = "取り扱い開始日" + "　" + datas[7];
                label_gondora.Text = "ゴンドラ" + "　" + datas[8];
                Program.SasWindow?.StatusMessage("情報を取得しました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("情報の表示にエラーが発生しました。 " + ex.Message);
            }

        }
    }
}
