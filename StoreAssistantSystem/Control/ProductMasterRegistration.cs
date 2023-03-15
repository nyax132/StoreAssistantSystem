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
    }
}
