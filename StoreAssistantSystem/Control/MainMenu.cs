namespace StoreAssistantSystem.Control
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            var ordermenu = new OrderMenu();
            Program.SasWindow.TransitionControl(ordermenu);
        }

        private void setting_button_Click(object sender, EventArgs e)
        {
            var settingmenu = new SettingMenu();
            Program.SasWindow.TransitionControl(settingmenu);
        }

        private void button_ProductMasterRegistration_Click(object sender, EventArgs e)
        {
            var pmr = new ProductMasterRegistration();
            Program.SasWindow.TransitionControl(pmr);
        }
    }
}
