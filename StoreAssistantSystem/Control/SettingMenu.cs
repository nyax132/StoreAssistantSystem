namespace StoreAssistantSystem.Control
{
    public partial class SettingMenu : UserControl
    {
        public SettingMenu()
        {
            InitializeComponent();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            var mainmenu = new MainMenu();
            Program.SasWindow.TransitionControl(mainmenu);
        }
    }
}
