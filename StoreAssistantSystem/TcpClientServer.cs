using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace StoreAssistantSystem
{
    public static class TcpClientServer
    {
        private static TcpClient? Client { get; set; }
        private static List<TcpClient> clients = new();

        public static async Task<string> SendMessage(string messagee)
        {
            if (Client == null || !Client.Connected)
            {
                Debug.WriteLine("サーバーに接続されていません");
                return "";
            }

            // メッセージを送信します。
            byte[] bytemessage = Encoding.UTF8.GetBytes(messagee);
            await Client.GetStream().WriteAsync(bytemessage, 0, bytemessage.Length);
            Debug.WriteLine($"Sent: {messagee}");

            // サーバーからの応答を受信します。
            try
            {
                // ネットワークストリームを作成します。
                NetworkStream stream = Client.GetStream();
                clients.Add(Client);

                byte[] buffer = new byte[1024];
                int bytesRead;

                while (true)
                {
                    // サーバーからのデータを非同期で読み取ります。
                    bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        // サーバーが切断された場合はループを抜けます。
                        break;
                    }

                    // 受信したデータを文字列に変換します。
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SocketException: {ex.Message}");
                Program.SasWindow?.StatusMessage("サーバーとの接続が切れていました。再接続をしてください", Color.Red);
                Program.SasWindow.toolStripSplitButton1.Visible = true;
                StopClient();
                return "";
            }
            return "";
        }

        public static async void ConnectServer(int port, string ipaddress)
        {
            Program.SasWindow?.StatusMessage("サーバー接続中・・・", Color.Black);
            IPAddress serverAddr = IPAddress.Parse(ipaddress);

            try
            {
                // TCPサーバーに接続します。
                Client = new TcpClient();
                await Client.ConnectAsync(serverAddr, port);
                Debug.WriteLine("サーバーに接続しました。");
                Program.SasWindow?.StatusMessage("サーバーに接続しました", Color.Black);
                Program.SasWindow.toolStripSplitButton1.Visible = false;
            }
            catch (SocketException ex)
            {
                Program.SasWindow?.StatusMessage("サーバーとの接続に失敗しました。設定を確認し、再接続してください", Color.Red);
                MessageBox.Show("サーバーとの接続に失敗しました。設定を確認し、再接続してください", "エラー");
                Program.SasWindow.toolStripSplitButton1.Visible = true;
                Debug.WriteLine($"SocketException: {ex.Message}");
                return;
            }
        }

        public static void StopClient()
        {
            // クライアント接続を閉じます
            foreach (TcpClient client in clients)
            {
                Debug.WriteLine("Clientを閉じました。");
                client.Close();
            }
            clients.Clear();
            Debug.WriteLine("サーバーとの接続を切断しました。");
        }
    }
}
