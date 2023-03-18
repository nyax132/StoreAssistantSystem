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
        /// �w�肳�ꂽControl�ɉ�ʂ��ڍs���܂�
        /// </summary>
        /// <param name="control">�ڍs����R���g���[��</param>
        public void TransitionControl(UserControl control)
        {
            Program.SasWindow?.StatusMessage("", Color.Black);
            if (oldcontrol != null)
            {
                Controls.Remove(oldcontrol);
                oldcontrol.Dispose();
                Debug.WriteLine(oldcontrol.Name + " :���폜���܂���");
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
            // ������̐擪���疖���܂ł��A�p�����݂̂ƃ}�b�`���邩�𒲂ׂ�B
            return Regex.IsMatch(text, @"^[0-9a-zA-Z]+$");
        }
    }
}