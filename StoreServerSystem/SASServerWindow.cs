namespace StoreServerSystem
{
    public partial class SASServerWIndow : Form
    {
        public SASServerWIndow()
        {
            InitializeComponent();
            SQLLisner.ProductMasterList.CreateTable();
            //SQLLisner.ProductMasterList.InsertRecord(004, "灯油", 108, 50, 1000, 100, 15000, "2020年4月27日", "1000:2:3");
        }

        private void button_serverstart_Click(object sender, EventArgs e)
        {
            TcpServer.ServerStart(textBox_serveradress.Text, int.Parse(textBox_serverport.Text));

            button_serverstart.Enabled = false;
            textBox_serveradress.Enabled = false;
            textBox_serverport.Enabled = false;
        }

        private void button_serverstop_Click(object sender, EventArgs e)
        {

            TcpServer.ServerStop();
            button_serverstart.Enabled = true;
            textBox_serveradress.Enabled = true;
            textBox_serverport.Enabled = true;
            loglistBox.Items.Add("\nサーバーを手動で終了しました。");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loglistBox.Items.Clear();
        }
    }
}