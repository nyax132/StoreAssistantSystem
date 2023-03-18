using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace StoreAssistantSystem
{
    public static class TcpClient
    {
        private static System.Net.Sockets.TcpClient? Client { get; set; }
        private static List<NetworkStream> NetworkStreams = new();
        private static List<System.Net.Sockets.TcpClient> clients = new();

        public static async Task<string> CommunicationToServer(string messagee)
        {
            if (Client == null || !Client.Connected)
            {
                Debug.WriteLine("サーバーに接続されていません");
                return "";
            }

            // メッセージを送信します。
            byte[] bytemessage = Encoding.UTF8.GetBytes(messagee);
            await Client.GetStream().WriteAsync(bytemessage, 0, bytemessage.Length);
            Debug.WriteLine($"Send: {messagee}");

            // サーバーからの応答を受信します。
            NetworkStream stream = null;
            try
            {
                // ネットワークストリームを作成します。
                stream = Client.GetStream();
                NetworkStreams.Add(stream);
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
                    Debug.Write($"Received: {data}");

                    //Errorが返ってきたらcatchする
                    if (data.StartsWith("Error"))
                    {
                        throw new Exception(data);
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SocketException: {ex.Message}");
                Program.SasWindow?.StatusMessage("エラーが発生しました。再接続をしてください", Color.Red);
                Program.SasWindow!.toolStripSplitButton1.Visible = true;
                StopClient();
            }
            return "";
        }

        public static async Task<bool> ConnectServer(int port, string ipaddress)
        {
            Program.SasWindow?.StatusMessage("サーバー接続中・・・");
            IPAddress serverAddr = IPAddress.Parse(ipaddress);

            try
            {
                // TCPサーバーに接続します。
                Client = new System.Net.Sockets.TcpClient();
                await Client.ConnectAsync(serverAddr, port);
                Debug.WriteLine("サーバーに接続しました。");
                Program.SasWindow?.StatusMessage("サーバーに接続しました");
                Program.SasWindow!.toolStripSplitButton1.Visible = false;
                return true;
            }
            catch (SocketException ex)
            {
                Program.SasWindow?.StatusMessage("サーバーとの接続に失敗しました。設定を確認し、再接続してください", Color.Red);
                Program.SasWindow!.toolStripSplitButton1.Visible = true;
                Debug.WriteLine($"SocketException: {ex.Message}");
                return false;
            }
        }

        public static void StopClient()
        {
            foreach (NetworkStream network in NetworkStreams)
            {
                Debug.WriteLine("NetworkStreamを閉じました。");
                network.Close();
            }

            foreach (System.Net.Sockets.TcpClient client in clients)
            {
                Debug.WriteLine("Clientを閉じました。");
                client.Close();
            }

            NetworkStreams.Clear();
            clients.Clear();
            Debug.WriteLine("サーバーとの接続を切断しました。");
        }
    }
}
