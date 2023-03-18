using System.Diagnostics;

namespace StoreAssistantSystem.Control
{
    public partial class ProductMasterRegistration : UserControl
    {
        public ProductMasterRegistration()
        {
            InitializeComponent();
        }

        private void button_backmenu_Click_1(object sender, EventArgs e)
        {
            var mainmenu = new MainMenu();
            Program.SasWindow.TransitionControl(mainmenu);
        }

        /// <summary>
        /// 登録ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_registration_Click(object sender, EventArgs e)
        {
            //productmaster insert 001 たばこ 200 350 5 1 5 2020年4月23日 1000:1:1
            //productmaster insert JAN NAME ORDERPRICE PRICE ORDERMINIMUM ORDERPERQUANTITY STOCK STARTOFHANDLING LOCATION
            var checkjanresult = await TcpClient.CommunicationToServer("productmaster serachjan " + textBox_jan.Text);
            if (checkjanresult != "notfound" & !checkBox_AllowOverwriting.Checked)
            {
                Program.SasWindow?.StatusMessage("すでに同じJANで登録されている商品があります。", Color.Red);
                return;
            }

            //更新(UPDATE)のときの処理
            if (checkBox_AllowOverwriting.Checked)
            {
                var updateresult = await TcpClient.CommunicationToServer($"productmaster update {textBox_jan.Text} {textBox_productname.Text} {textBox_costprice.Text} {textBox_sellingprice.Text} " +
                $"{textBox_Minimumorderquantity.Text} {textBox_Perorderquantity.Text} {textBox_stock.Text} {dateTimePicker_Dateofcommencementofhandling.Text} {textBox_gondora.Text}");
                if (updateresult == "SUCCESS")
                {
                    Program.SasWindow?.StatusMessage("更新しました。");
                }
                else
                {
                    Program.SasWindow?.StatusMessage("更新に失敗しました。", Color.Red);
                }
                return;
            }

            //追加(INSERT)のときの処理
            var insertresult = await TcpClient.CommunicationToServer($"productmaster insert {textBox_jan.Text} {textBox_productname.Text} {textBox_costprice.Text} {textBox_sellingprice.Text} " +
                $"{textBox_Minimumorderquantity.Text} {textBox_Perorderquantity.Text} {textBox_stock.Text} {dateTimePicker_Dateofcommencementofhandling.Text} {textBox_gondora.Text}");
            if (insertresult == "SUCCESS")
            {
                Program.SasWindow?.StatusMessage("登録しました。");
            }
            else
            {
                Program.SasWindow?.StatusMessage("登録に失敗しました。", Color.Red);
            }
            ResetData();
        }

        /// <summary>
        /// 情報照会ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_CompetitiveChecking_Click(object sender, EventArgs e)
        {
            var result = await TcpClient.CommunicationToServer("productmaster serachjan " + textBox_jan.Text);
            if (result == "notfound")
            {
                ResetData();
                Program.SasWindow?.StatusMessage("商品が見つかりませんでした。", true);
                return;
            }

            SetData(result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        /// <summary>
        /// 削除ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_delete_Click(object sender, EventArgs e)
        {
            var deleteresult = await TcpClient.CommunicationToServer("productmaster delete " + textBox_jan.Text);
            if (deleteresult == "SUCCESS")
            {
                Program.SasWindow?.StatusMessage("削除しました。");
            }
            else
            {
                Program.SasWindow?.StatusMessage("削除に失敗しました。", Color.Red);
            }
            ResetData();
        }

        /// <summary>
        /// 情報をFormに表示します。
        /// </summary>
        /// <param name="datas"></param>
        private void SetData(string[] datas)
        {
            try
            {
                textBox_productname.Text = datas[1];
                textBox_costprice.Text = datas[2];
                textBox_sellingprice.Text = datas[3];
                textBox_Minimumorderquantity.Text = datas[4];
                textBox_Perorderquantity.Text = datas[5];
                textBox_stock.Text = datas[6];
                dateTimePicker_Dateofcommencementofhandling.Text = datas[7];
                textBox_gondora.Text = datas[8];
                Program.SasWindow?.StatusMessage("情報を取得しました。");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("情報の表示にエラーが発生しました。 " + ex.Message);
            }

        }
        /// <summary>
        /// 情報をリセットします
        /// </summary>
        /// <param name="datas"></param>
        private void ResetData()
        {
            DateTime dt = DateTime.Now;

            textBox_productname.Text = "";
            textBox_sellingprice.Text = "";
            textBox_costprice.Text = "";
            textBox_Minimumorderquantity.Text = "";
            textBox_Perorderquantity.Text = "";
            textBox_stock.Text = "";
            dateTimePicker_Dateofcommencementofhandling.Text = dt.ToString("d");
            textBox_gondora.Text = "";
        }
    }
}
