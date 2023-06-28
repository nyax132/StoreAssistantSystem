namespace StoreServerSystem
{
    public partial class SASServerWIndow : Form
    {
        public SASServerWIndow()
        {
            InitializeComponent();
            SQLLisner.SQLListener.ParseDatabaseAction("productmaster createtable");
            SQLLisner.SQLListener.ParseDatabaseAction("ordermaster createtable");
            //SQLLisner.SQLListener.ParseDatabaseAction("productmaster insert 004 ���� 50 108 1000 100 15000 2020�N4��27�� 1000:2:3");
        }

        private async void button_serverstart_Click(object sender, EventArgs e)
        {
            await TcpServer.ServerStart(textBox_serveradress.Text, int.Parse(textBox_serverport.Text));

            button_databaseoptimization.Enabled = false;
            button_serverstart.Enabled = false;
            textBox_serveradress.Enabled = false;
            textBox_serverport.Enabled = false;
        }

        private void button_serverstop_Click(object sender, EventArgs e)
        {

            TcpServer.ServerStop();
            button_databaseoptimization.Enabled = true;
            button_serverstart.Enabled = true;
            textBox_serveradress.Enabled = true;
            textBox_serverport.Enabled = true;
            loglistBox.Items.Add("\n�T�[�o�[���蓮�ŏI�����܂����B");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loglistBox.Items.Clear();
        }

        private void button_databaseoptimization_Click(object sender, EventArgs e)
        {

        }
    }
}