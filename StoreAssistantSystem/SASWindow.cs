using StoreAssistantSystem.Control;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Text;

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

            TcpClientServer.ConnectServer(55555, "127.0.0.1");
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
            toolStripStatusLabel1.Text = message;
            toolStripStatusLabel1.ForeColor = color;
        }

        private void SASWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            TcpClientServer.StopClient();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            TcpClientServer.ConnectServer(55555, "127.0.0.1");
        }
    }
}