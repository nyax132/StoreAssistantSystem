using StoreAssistantSystem.Control;
using System.Diagnostics;
using System.Media;
using System.Text.RegularExpressions;

namespace StoreAssistantSystem
{
    public partial class SASWindow : Form
    {
        private UserControl? oldcontrol;
        public SASWindow()
        {
            InitializeComponent();
            var mainmenu = new MainMenu();
            TransitionControl(mainmenu);

            TcpClient.ConnectServer(55555, "127.0.0.1");
        }

        /// <summary>
        /// 指定されたControlに画面を移行します
        /// </summary>
        /// <param name="control">移行するコントロール</param>
        public void TransitionControl(UserControl control)
        {
            Program.SasWindow?.StatusMessage("", Color.Black);
            if (oldcontrol != null)
            {
                Controls.Remove(oldcontrol);
                oldcontrol.Dispose();
                Debug.WriteLine(oldcontrol.Name + " :を削除しました");
            }

            this.Size = (Size)new Point(control.Size.Width, control.Size.Height + 50);
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            oldcontrol = control;
        }

        public void StatusMessage(string message, Color color)
        {
            if (color == Color.Red) SystemSounds.Hand.Play();

            toolStripStatusLabel1.Text = message;
            toolStripStatusLabel1.ForeColor = color;
        }

        public void StatusMessage(string message, bool notice_sound = false)
        {
            if (notice_sound) SystemSounds.Asterisk.Play();
            toolStripStatusLabel1.Text = message;
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void SASWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            TcpClient.StopClient();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            TcpClient.ConnectServer(55555, "127.0.0.1");
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