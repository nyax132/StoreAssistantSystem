namespace StoreAssistantSystem.Control
{
    public partial class SettingMenu : UserControl
    {
        public SettingMenu()
        {
            InitializeComponent();

            textBox_ip.Text = Program.IpAddress;
            textBox_port.Text = Program.Port.ToString();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            var mainmenu = new MainMenu();
            Program.SasWindow.TransitionControl(mainmenu);
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.IPaddress = textBox_ip.Text;
            Properties.Settings1.Default.Port = int.Parse(textBox_port.Text);
            Properties.Settings1.Default.Save();
            Program.SasWindow?.StatusMessage("設定を保存しました。", true);
        }
    }
}
