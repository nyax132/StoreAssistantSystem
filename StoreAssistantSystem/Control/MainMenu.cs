using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void button_ProductMasterRegistration_Click(object sender, EventArgs e)
        {
            var pmr = new ProductMasterRegistration();
            Program.SasWindow.TransitionControl(pmr);
        }
    }

    public class Components
    {
        public static bool IsOnlyAlphanumeric2(string text)
        {
            // 文字列の先頭から末尾までが、英数字のみとマッチするかを調べる。
            return Regex.IsMatch(text, @"^[0-9a-zA-Z]+$");
        }
    }
}
